<?php
	session_start();
	?>
<html>
<body>

Search for a flight:

<form action =" " medthod="POST">
Flight Name: <input type= "text" name=  "Flight">
<input type= "Submit" name="Submitbutton" Value="Submit">

<br>
DepartureDate: <input type= "text" name= "Dept">
<input type= "Submit" name="Submitbutton" Value="Submit">
<br>

Destination: <input type= "text" name= "Phone">
<input type= "Submit" name="Submitbutton" Value="Submit">
</form>

<?php

if(isset($_POST ["Submitbutton"]))
{
	$_SESSION["FlightName"]= ["Flight"];
	$_SESSION["Destination"]= ["Dest"];
	$_SESSION["DepartureDate"]=["Dept"];
	
	$_SESSION["Search"];

$Search="Select FlightName, Destination, DepartureDate From Flights Where FlightName='".$Flight."' AND DepartureDate='".$Dept."' AND Destination= '".$Dest."';";

			if(! $Search)
	{die (" Query failed ");
		echo $Search;
	}
	
	else
	{
		header("Location:ResultsPg.php");
	}
}

?>
