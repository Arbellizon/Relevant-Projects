
<?php
session_start();
?>


<html>
<body>

You searched for: <?php echo $_POST["Flight"]; ?>
	<br/>
		<?php echo $_POST["Dept"]; ?>
			<br/>
				<?php echo $_POST["Dest"]; ?>
</form>
	
<?php	
$num_of_rows=mysql_numrows($Search);
$i=0;while($i <$num_of_rows)
{
	$i++;
}

$FlightName= mysql_result($Search,$i,"Flight");
$Destination= mysql_result($Search,$i,"Dest");
$DepartureDate= mysql_result($Search,$i,"Dept");

if(! $FlightName or $Destination or $DepartureDate)
	{ die
		("Sorry, No Flights under this category!");
	}
else
{
	$_SESSION ["FlightName"]=$Flight;
		header("Location:Confirmation.php");
}

?>

</body>
</html>