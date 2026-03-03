let filenev  = "vonat.txt";
const adatok = [];
betolt();
function betolt()
{
    fetch(filenev)
    .then(x => x.text())
    .then(x => {
        /*
        console.log(x);
        // 1 0   5   45
        //let minta = /(\d+)\t(\d+)\t(\d+)\t([IE])/g;
        let minta = /(\d+)\s+(\d+)\s+(\d+)\s+([IE])/g;
        let eredmeny = x.match(minta);
        console.log(eredmeny.groups, eredmeny);
        */
       const regex = /^(?<vonatId>\d+)\s(?<allomasId>\d+)\s(?<ora>\d+)\s(?<perc>\d+)\s+(?<tipus>[IE])$/gm;
       let match;
       while ((match = regex.exec(x)) !== null)
        {
            adatok.push(match.groups);
        }
        console.log(adatok);
    });
}
