const kepek = ["buttonchoose.jpg","meme_will_smith.jpg","lookat.jpg","manlooking.jpg","big_dog.jpg","spiderman.jpg","dragons.jpg","jesus_saving.jpg","nutella.jpg","peter_griffin.jpg","gta_6.jpg","pooh.jpg", "cat_looking.jpeg", "credo.jpg","dragons.jpg", "GTA_5_characters.png", "hello_kitty.jpg", "nessaj.png", "the_end.png", "platform6.png", "spongebob.png", "rock.png", "open_mic.jpg", "hello_neighbor.png"]

const kepDarab = 24;
let pakli = [];

function init()
{
	let seged = 0;

    for (let i = 0; i < kepDarab; i++)
    {
        let temp = document.createElement("div");
        temp.classList.add("kartya");
        //temp.style.backgroundImage = `url(${kepek[i]})`;
		//temp.style.backgroundImage = "url(" + kepek[seged] + ")";
		temp.dataset.kep = "url(" + kepek[seged] + ")";
		//temp.style.backgroundImage = "url(" + kepek[Math.floor(i/2)] + ")";

		temp.onclick = function()
		{
			
		}

        pakli.push(temp);
        //document.getElementById("asztal").appendChild(temp);

		seged++;
		if(seged >= kepDarab / 2)
		{
			seged = 0;
		}
    }

	pakli = shuffleArray(pakli);
	for (let i = 0; i < pakli.length; i++)
	{
		document.getElementById("asztal").appendChild(pakli[i]);
	}
}


function shuffleArray(array) {
    for (let i = array.length - 1; i >= 1; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }

	return array;
}

