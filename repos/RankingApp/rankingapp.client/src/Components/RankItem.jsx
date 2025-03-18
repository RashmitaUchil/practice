import { useState, useEffect } from 'react'
import axios from 'axios'
function RankItem() {
    const [items, setItems] = useState([]);
    const dataType = 1;
    useEffect(() => {
        axios.get(`http://localhost:5000/item/${dataType}`)
            .then((results) => {
                setItems(results.data);
            })
            .catch((error) => console.log("could not fetch items:", error));
    },)
    return (
        <main>
            {(items != null) ?
                items.map((item) => <h1 key={item.id}>{item.title}</h1>)
                :
                <p>No items found.</p>
            }
        </main>
    );
}

export default RankItem;