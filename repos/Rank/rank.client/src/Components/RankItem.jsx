import { useState, useEffect } from 'react'
function RankItem() {
    const [items, setItems] = useState([]);
    //const dataType = 1;
    useEffect(() => {
        fetch(`/rankitem/1`)
            .then((response) => {
                console.log("Response status:", response.status);
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                return response.json(); // Parse JSON response
            })
            .then((data) => {
                setItems(data); // Update items state
            })
            .catch((error) => console.error("Could not fetch items:", error));
    }, []);
    return (
        <div>
            {(items != null) ?
                (items.map((item) => <h1 key={item.Id}>{item.Title}</h1>)) :
                (<p>no items found</p>)
            }
        </div>
    );
}

export default RankItem;