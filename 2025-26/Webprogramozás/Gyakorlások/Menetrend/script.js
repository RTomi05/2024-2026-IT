let filenev  = "vonat.txt";
const adatok = [];
betolt();
function betolt()
{
    fetch(filenev)
    .then(x => x.text())
    .then(x => {
       const regex = /^(?<vonatId>\d+)\s+(?<allomasId>\d+)\s(?<ora>\d+)\s(?<perc>\d+)\s(?<tipus>[IE])$/gm;

       let match;
       let sorok2 = x.match(regex);
       
       while ((match = regex.exec(x)) !== null)
        {
            adatok.push(match.groups);
            adatok.at(-1)["idoPercben"] = parseInt(adatok.at(-1).ora) * 60 + parseInt(adatok.at(-1).perc);
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
    let vonatSzamkiir = document.getElementById("vonatSzam");

    let allomasSzamkiir = document.getElementById("allomasSzam");

    let vonatMax = 0;
    let allomasMax = 0;

    adatok.forEach(x => {

        if(parseInt(x.vonatId) > vonatMax )
        {
            vonatMax = parseInt(x.vonatId);
            

        }
        if(parseInt(x.allomasId) > allomasMax)
        {
            allomasMax = parseInt(x.allomasId);
        }
    })

    vonatSzamkiir.innerHTML = vonatMax;

    allomasSzamkiir.innerHTML = allomasMax+1;
}

function feladat3()
{
    let rendezett = adatok.toSorted((a, b) => parseInt(a.allomasId) - parseInt(b.allomasId))
    .toSorted((a, b) => parseInt(a.vonatId) - parseInt(b.vonatId));

    const varakozasok = [,[]];
    for(let i = 1; i < rendezett.length-1; i+=2)
    {
        if(rendezett[i].vonatId !== rendezett[i+1].vonatId)
        {
            varakozasok.push([]);
        }
        else
        {
            varakozasok[rendezett[i].vonatId].push(rendezett[i+1].idoPercben - rendezett[i].idoPercben);
        }
    }

    let max = -1;
    let maxVonat = 0;
    let maxAllomas = 0;

    for(let i = 1; i < varakozasok.length; i++)
    {
        for(let k = 0; k < varakozasok[i].length; k++)
        {
            if(max<varakozasok[i][k])
            {
                max = varakozasok[i][k];
                maxVonat = i;
                maxAllomas = k+1;
            }
        }
    }

    //console.log(...varakozasok.flat());
    max = Math.max(...varakozasok.flat());
    const szurt = varakozasok.filter(egyVonat => {
    let f = egyVonat.filter(egyIdo => egyIdo === max);
    return f;
    });
    szurt.filter((x,i) => {
        if(x.length > 0)
        {
            return i;
        }
    })

    console.log(szurt);

    document.getElementById("vonatId").innerHTML = maxVonat;
    document.getElementById("allomas").innerHTML = maxAllomas;
    document.getElementById("varakozasido").innerHTML = max;

    console.log(rendezett, varakozasok);
}