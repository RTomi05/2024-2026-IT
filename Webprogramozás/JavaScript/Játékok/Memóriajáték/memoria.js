const kepek = ["buttonchoose.jpg","meme_will_smith.jpg","lookat.jpg","manlooking.jpg","big_dog.jpg","spiderman.jpg","dragons.jpg","jesus_saving.jpg","nutella.jpg","peter_griffin.jpg","gta_6.jpg","pooh.jpg", "cat_looking.jpeg", "credo.jpg","dragons.jpg", "GTA_5_characters.png", "hello_kitty.jpg", "nessaj.png", "the_end.png", "platform6.png", "spongebob.png", "rock.png", "open_mic.jpg", "hello_neighbor.png"]

const kepDarab = 4;
let pakli = [];

let felforditva = [];

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
			if(felforditva.length < 2)
			{
				if(!(felforditva.length === 1 && felforditva[0] === this))
				{
					this.style.backgroundImage = this.dataset.kep;
					felforditva.push(this);
					console.log(felforditva);
				}
				
			}

			if(felforditva.length >= 2)
			{
				egyenloE();
			}
			
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

function egyenloE()
{
	//console.log(felforditva);
	if(felforditva[0].style.backgroundImage === felforditva[1].style.backgroundImage)
	{
		felforditva[0].onclick = "";
		felforditva[1].onclick = "";
		felforditva = [];
		checkGameOver();
	}

	else
	{
		setTimeout(visszafordit, 1000)
	}
}


function checkGameOver()
{
	let gameover = true;
	for(let i = 0; i < pakli.length && gameover; i++)
	{
		gameover = gameover && pakli[i].style.backgroundImage !== "";
	}

	if(gameover)
	{
		console.log("Game Over!");
		let end = document.createElement("div");
		end.classList.add("gameover");
		end.innerHTML = "Game Over!";
		document.body.appendChild(end);
	}
}


function visszafordit()
{
	for(let i = 0; i < felforditva.length; i++)
	{
		felforditva[i].style.backgroundImage = "";
	}

	felforditva = [];
}

function shuffleArray(array) {
    for (let i = array.length - 1; i >= 1; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }

	return array;
}

