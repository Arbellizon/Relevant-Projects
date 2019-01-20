//HANDLES NON SYNTAX AND LOGIC ERRORS ACROSS PAGE
window.onerror = function OneOfMany(msg, url,line,col,err)
{alert('Message: '+msg+'\n line: '+line+', '+'\ncolumn: '+col+'!!!'); 
console.log('\nErrMess:'+line+'\nErr:'+err+'\nline: '+line+',' +'column:'+col+'!!!') 
return true;}


//handles button ajax calls
  

window.onload = function()
{//when label is clicked
    
    $.getScript('timer.js', function(data)
    {
        console.log("file waz loaded successfully");
        tickTock();
    });
    var btn = document.querySelector("#labelbtn");
    var btn2 = document.querySelector("#btn");
    //btn.disabled = false;
    btn.onclick = Request;
    btn2.onclick = guessWhat;
    
    // maybe disable button here btn.disabled = true;
}
var num = -1;
var min, max, ran;

function Request()
{
    // will request images and price from server
    num++;
    $.ajax({url: "image.php", success: function(data)
    { 
        console.log(data);
          
        var dataObj = JSON.parse(data);
        
        console.log(dataObj);
        console.log(dataObj.image_url);
        
        console.log(dataObj[0].min_price);
        console.log(dataObj[0].max_price);   

        $("#prize").css("background-image",'url(" '+ dataObj[num].image_url+' ")');
        document.getElementById("description").textContent = dataObj[num].description;
        min =dataObj[num].min_price;
        max =dataObj[num].max_price;
        sum = dataObj[num].min_price + dataObj[num].max_price;
        
        
        
         ran = Math.floor(Math.random() *(max-min)+min); // figure out how to randomly get value for price
        
        if (ran < min) {
            ran = min;
        }

        if (ran > max) {
            ran = max;
        }

        console.log("min max line 46",min, max);  
         console.log("line 48 sum",sum);
        console.log("line 50 ran",ran);
       
       guessWhat();
     /*
       
        $("#prize").each(function(dataObj)
         {
            for(var i = 0 in dataObj[i])
            {
                 var img = dataObj[i].image_url;
               $(this).css("background-image",'url(" '+img +' ")');
            }
                 
            dataObj[Math.floor(Math.random() * dataObj.length-1)].image_url;
        }); 
       // $("#prize").css("background-image",'url(" '+ img+' ")');
       
console.log(dataObj[0]);
        

        
          console.log(dataObj);
      for(var i = 0; i<2; i++)
      {
            var img = dataObj[i];

            console.log(img);
      }*/
        
    }});
    
}

function guessWhat()
{
    var guessTextbox = document.querySelector("#userinput");
    var display = document.querySelector("#price");
    var pressed = document.querySelector("#btn");
    var guess = guessTextbox.value;

    console.log("You guessed" + guess +" and the random price is"+ ran);

    if(guess === "")
    {
        display.textContent = " That wasn't a guess, times ticking";
        return;
    }

     if(isNaN(guess))//compare guess to stored value
    {
        display.textContent = "tickTock";
        return;
    }
    
    if(guess< ran)
    {
       display.textContent = " Higher Tick Tock";
       console.log(ran);
    }
    else if(guess> ran)
    {
        display.textContent = " Lower Tick Tock";
        console.log(ran);
    }
    else
    {
         document.querySelector("#labelbtn").disabled = false;
        display.textContent = " CORRECT,CLICK TO PLAY AGAIN";

         console.log(ran);
        
    }


}