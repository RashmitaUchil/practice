using System.Xml;
using System.Xml.Serialization;

namespace Adapter.Adaptee
{
    [Serializable]
    public class Employee
    {
        public enum EmployeeType
        {
            Permanent,
            Contract
        }

        public enum Position
        {
            Manager,
            Other
        }

        public Employee()
        { }

        public Employee(int id, string name)
        {
            ID = id;

            Name = name;
        }

        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public EmployeeType Type { get; set; }
        public Position position;
    }

    public class EmployeeManager
    {
        public List<Employee> employees = new List<Employee>();

        public EmployeeManager()
        {
            employees.Add(new Employee(1, "Mike"));
            employees.Add(new Employee(2, "Smith"));
            employees.Add(new Employee(3, "Rose"));
            employees.Add(new Employee(4, "Lisa"));
        }

        public virtual string GetAllEmployees()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });
            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees, emptyNamespaces);
                return stream.ToString();
            }
        }
    }
}