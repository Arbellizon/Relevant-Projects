Menu.php
<br>
<br>
<?php
	session_start();
	?>
	
<html>
<body>

<br>
Would you like to:

<br>
Reserve a flight? 
<input type= "Submit" name= "Submitbutton1" value= "Reserve">
<br>

or
<br>
<br>
View a previous Reservation 

<input type= "Submit" name= "Submitbutton2" value= "View">
<br>
<br>

</form>

<?php	
	
	if((isset($_POST ["Submitbutton1"])))
	{
		$Raf= $_POST["Reserve"];
		header("Location:Search.php");
	}
	else if((isset($_POST ["Submitbutton2"])))
	{
		$Vapr= $_POST["View"];
		header("Location:PreviousRes.php");
	}
	else
	{
		die
		("ERROR! Could not Redirect.");
	}
	
	?>
	</body>
	</html>