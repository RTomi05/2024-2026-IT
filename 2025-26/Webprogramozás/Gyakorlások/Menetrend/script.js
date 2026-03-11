let filenev  = "vonat.txt";
const adatok = [];
betolt();
function betolt()
{
    fetch(filenev)
    .then(x => x.text())
    .then(x => {
       const regex = /^(?<vonatId>\d+)\s(?<allomasId>\d+)\s(?<ora>\d+)\s(?<perc>\d+)\s+(?<tipus>[IE])$/gm;

       let match;
       
       while ((match = regex.exec(x)) !== null)
        {
            adatok.push(match.groups);
        }
        console.log(adatok);
    });
}

/*
Írja a képernyőre a fájlban tárolt vonatok és állomások darabszámát – a kezdő és
végállomást is beleértve! */

function feladat2()
{
    console.log("2. feladat:");
    let vonatSzam = document.getElementById("vonatSzam");
    let allomasSzam = document.getElementById("allomasSzam");
}

function feladat3()
{
    let rendezett = adatok.toSorted((a, b) => parseInt(a.allomasId) - parseInt(b.allomasId))
    .toSorted((a, b) => parseInt(a.vonatId) - parseInt(b.vonatId));

    const varakozasok = [];
    for(let i = 1; i < rendezett.length; i++)
    {
        varakozasok.push(rendezett[i+1].idoPerc - rendezett[i].idoPerc);
    }

    console.log(rendezett);
}