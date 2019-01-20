 function tickTock()
  {
  var display = document.querySelector('#displaytime');
  var labelclicked = document.querySelector('#labelbtn');
        timer = new CountDownTimer(30);
        timeObj = CountDownTimer.parse(30);

        format(timeObj.minutes, timeObj.seconds);
        timer.onTick(format);

        labelclicked.addEventListener('click', function () {
          
            timer.start();
            labelclicked.disabled =true;

          //add disable buttton
      });
     
  
    function format(minutes, seconds) 
    {
      minutes = minutes < 10 ? "0" + minutes : minutes;
      seconds = seconds < 10 ? "0" + seconds : seconds;
     display.textContent = minutes + ':' + seconds;
       display.style.textAlign = "center";
       display.style.fontWeight = "bolder";
       document.querySelector("#time").style.border = "100% solid black";
      display.style.fontSize = "500%";
     
    }

   
  };
  
  function CountDownTimer(duration, granularity) {
    this.duration = duration;
    this.granularity = granularity || 1000;
    this.tickFtns = [];
    this.running = false;
  }
  
  CountDownTimer.prototype.start = function() {
    if (this.running) {
      return;
    }
    this.running = true;
    var start = Date.now(),
        that = this,
        diff, obj;
  
    (function timer() {
      diff = that.duration - (((Date.now() - start) / 1000) | 0);
      
      if (diff > 0) {
        setTimeout(timer, that.granularity);
      } else {
        diff = 0;
        that.running = false;
      }
  
      obj = CountDownTimer.parse(diff);
      that.tickFtns.forEach(function(ftn) {
        ftn.call(this, obj.minutes, obj.seconds);
      }, that);
    }());
  };
  
  CountDownTimer.prototype.onTick = function(ftn) {
    if (typeof ftn === 'function') {
      this.tickFtns.push(ftn);
    }
    return this;
  };
  
  CountDownTimer.prototype.expired = function() {
    return !this.running;
  };
  
  CountDownTimer.parse = function(seconds) {
    return {
      'minutes': (seconds / 60) | 0,
      'seconds': (seconds % 60) | 0
    };
  };