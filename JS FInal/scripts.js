//creates the nice "Vue" :]
const vue = new Vue({
   
    el: "#app",
    data() {
 // sets up varibles
        return {
            celsius: " ",
            fahrenheit: " ",
            tempature: " ",
            weathertype: " ",
            //url: "http://openweathermap.org/img/wn/10d@",
            pic: " ",
            //png: ".png",
            zip: `65619`,
            city: " "

        }

    },

    methods: {

        // in submit, the zip is pulled from the entered data and the api is called using that zip.
        callWeather() {
            zip = document.getElementById("new").value; // user given zip
            
            // everything falls within an if statment. If the users zip doesn't fall beteen the possible zip codes then they are given an error 

            if (zip > 00501 && zip < 99950) {
                //instead of being mounted the api call happens on the submiting of the zip
                axios.get(`https://api.openweathermap.org/data/2.5/weather?zip=` + zip + `,us&appid=6cf453672d0583aab3c805878216696e`)
                    .then((response) => {
                        // these are where the information about the weather are pulled from the api
                        this.weathertype = response.data.weather[0].description;
                        this.pic = response.data.weather[0].icon;
                        this.tempature = response.data.main.temp;
                        this.city = response.data.name
                        
                        //the icon
                        document.getElementById(`icon`).src = "http://openweathermap.org/img/wn/" + this.pic + "@2x.png"


                        // the radio buttons are checked and depending on whichever is clicked that math function is ran to convert from kelvin to the chosen type. 
                        var radios = document.getElementsByName('temptype');

                        for (var i = 0, length = radios.length; i < length; i++) {
                            if (radios[i].checked && radios[i].id == "fahrenheit") {

                                this.tempature = Math.round((this.tempature - 273.15) * 9 / 5 + 32)

                                //(0K − 273.15) × 9/5 + 32

                            }
                            if (radios[i].checked && radios[i].id == "celsius") {
                                this.tempature = Math.round((this.tempature - 273.15))

                                //(0K − 273.15)
                            }
                        }
                    })
                    
                    // if a 404 is thrown becuase the user put in a zip that doesn't exist they are notified 
                    .catch(e => {
                        if (e.response.status === 404) {

                            
                            var node = document.createTextNode(`The Zipcode you entered \(` + zip + `\) was unable to be pulled by the API`);
                            error.appendChild(node);
                            var element = document.getElementById("app");
                            element.appendChild(error);
                        }
                    });








            } else {

                
                var node = document.createTextNode(`Zipcode Must contain five numbers between 00501 and 99950. The Zipcode you entered \(` + zip + `\) is invalid`);
                error.appendChild(node);
                var element = document.getElementById("app");
                element.appendChild(error);
            }


        }
    },
    //grabs the api and creates the arrqts variable 
    // mounted()
    // {
    //     axios.get(`https://api.openweathermap.org/data/2.5/weather?zip=`+this.zip+`,us&appid=6cf453672d0583aab3c805878216696e`)

    //     .then( (response) => {
    //         this.weather = response.data;
    //         // console.log(this.weather)
    //     })



    // } 

    //if (radios[i].checked && radios[i].id == "celsius")
})