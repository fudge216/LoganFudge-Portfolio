//Logan Fudge
//CIS 131
//Rocket Launch


$('#station').click( ()=> {    
    //This use of query allows me to grab the api of the space stations and 
    $.get("https://lldev.thespacedevs.com/2.0.0/spacestation/",(data) => {
            
        data.results.forEach( (element, index ,array )=> {
        //Using JQuery I created inline html elements and with in the HTML the info is put into a bootstap card for each result.
            $("#space").append('<div class="card" style="width: 14em;">')
            $("#space").append(`<img class="card-img-top" style=" width: 225px;" src="${element.image_url}" alt="Card image cap">`)
            $("#space").append(`<div class="card-body" style=" width: 225px"><p>${element.name} <br> ${element.founded} <br> ${element.deorbited} <br> ${element.orbit} </p></div>`)
        
            // started with this but could only print the last of the pictures 
            // imgs = document.getElementById('imgs')
            // pics = element.image_url  
            // imgs.src = pics
            // console.log(imgs.src)
        })
        //gets rid of the button
        $("#station").hide(0)
    })})
    
    $('#astronauts ').click( ()=> {    
        //This use of query allows me to grab the api of the astronauts  
        $.get("https://lldev.thespacedevs.com/2.0.0/astronaut",(data) => {
                
            data.results.forEach( (element, index ,array )=> {
            //Using JQuery I created inline html elements and with in the HTML the info is put into bootstap for each result.
                $("#astro").append('<div class="card" style="width: 14em;">')
                $("#astro").append(`<img class="card-img-top" style=" width: 225px;" src="${element.profile_image}" alt="Card image cap">`)
                $("#astro").append(`<div class="card-body"><p>${element.name} <br> ${element.bio} <br> Currently: ${element.status.name}</p></div>`)
            })
            //gets rid of the button
            $("#astronauts").toggle(0)
        })})


        
