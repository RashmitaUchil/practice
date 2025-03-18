using System;
using Microsoft.EntityFrameworkCore;
using Students.Api.Data;
using Students.Api.Dtos;
using Students.Api.Entities;
using Students.Api.Mapping;

namespace Students.Api.Endpoints;

public static class StudentEndpoints
{
    const string GetStudent="GetStudent";
    public static RouteGroupBuilder MapStudentEndpoints(this WebApplication app)
    {
        var group=app.MapGroup("student").WithParameterValidation();
        //GET
        group.MapGet("/",async (StudentContext dbContext)=> 
         await dbContext.Students
                .Include(s => s.dept)
                .Select(student=>student.ToStudentSummaryDto())
                .AsNoTracking()
                .ToListAsync() );


        group.MapGet("/{id}",async (int id, StudentContext dbContext)=>
        {
            Student? student = await dbContext.Students.FindAsync(id);

            return student is null? Results.NotFound():Results.Ok(student.ToStudentDetailsDto());
        })
        .WithName(GetStudent);

        //POST
        group.MapPost("/",async (CreateStudent newStudent, StudentContext dbContext)=>
        {

           Student student=newStudent.ToEntity();

            dbContext.Students.Add(student);
            await dbContext.SaveChangesAsync();

            

            return Results.CreatedAtRoute(GetStudent, new{id=student.Id}, student.ToStudentDetailsDto());
        }
        ).WithParameterValidation();

        //PUT
        group.MapPut("/{id}",async (int id,UpdateStudent updateStudent, StudentContext dbContext)=>
        {
            var existingStudent = await dbContext.Students.FindAsync(id);
            if (existingStudent is null)    
            {
                return Results.NotFound();
            }
            
            dbContext.Entry(existingStudent)
                        .CurrentValues
                        .SetValues(updateStudent.ToEntity(id));

            await dbContext.SaveChangesAsync();
            
                return Results.NoContent();
        });

        //DELETE
        group.MapDelete("/{id}",async (int id, StudentContext dbContext)=>
        {
            await dbContext.Students.Where(student=>student.Id == id)
            .ExecuteDeleteAsync();
            return Results.NoContent();
        });
        return group;

    }
}
