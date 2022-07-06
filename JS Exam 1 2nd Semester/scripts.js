//Variables 
var myPics = ["Mando.jpg","FullMetal.png","Shine.jpg","spider.png"]
var largeImg = document.getElementById("main");
var smlImg = document.getElementById('pics')
//On window, loads small imgs
window.addEventListener('load',function() {
  addImg()
})

//function to create images
function addImg(){
    //loop that adds images from array and gives them style
    for(var i=0; i< myPics.length; i++)
    {
    pic = document.createElement('img')
    pic.src= "Imgs/"+myPics[i]
    pic.addEventListener('click', imgSwitch)
    pic.style.height= "200px" 
    pic.style.width= "200px"
    smlImg.appendChild(pic)
      
    }
    //creates Large img
    largeImg.src="Imgs/"+ myPics[0] 
    
}

//switches small to large img
function imgSwitch(e)
{
    var myImg = document.getElementById('main')
    myImg.src=e.target.src   
}




//sets up variables for select 1 to pick an img
var select1 = document.getElementById("choice"); 
var topArray = ["Mandolorian","Full Metal Alchemist","Shinesprite","Spider-man"]

//adds array to select 1 via loop
for(var i = 0; i < topArray.length; i++) {
    var option1 = document.createElement("OPTION"),
    txt = document.createTextNode(topArray[i]);
    option1.appendChild(txt);
    option1.setAttribute("value",topArray[i]);
    select1.insertBefore(option1,select1.lastChild);
    
}
//sets up variables for select 2 to pick quantity
var select2 = document.getElementById("number"); 
var numArray = ["1","2","3","4","5","6","7","8","9","10"]

//adds array to select 2 via loop
for(var i = 0; i < numArray.length; i++) {
    var option2 = document.createElement("OPTION"),
    txt = document.createTextNode(numArray[i]);
    option2.appendChild(txt);
    option2.setAttribute("value",numArray[i]);
    select2.insertBefore(option2,select2.lastChild);
}
//butt summons clicker function
butt.addEventListener('click', clicker)

//sends data from form to li via their id
function clicker()
{
    
    var confirm = document.getElementById('confirm');
    var name = document.getElementById('name').value;
    var amt=number.value


    myString = "<ul>"
    myString += "<li> Name: " +  document.getElementById('name').value + "</li>"
    myString += "<li> Your Photo: " +  document.getElementById('choice').value + "</li>"
    myString += "<li> Quantity of Photos: " +  document.getElementById('number').value + "</li>"
    myString += "</ul>";
    confirm.innerHTML = myString;
    
}

