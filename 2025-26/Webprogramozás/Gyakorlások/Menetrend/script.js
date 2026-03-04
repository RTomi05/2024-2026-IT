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
}
