Confirmation.php

<?php
session_start();
?>

<html>
<body>
Here is the flight you have reserved:
</form>

<?php

$Query_to_Database=
$results_of_Query=conn->query($Query_to_Database);

if($results_of_Query->num_rows>0)
{
	//output data of each row
	while($row=$results_of_Query->fetch_assoc())
	{
		echo $row["FlightID"];
		echo $row["FlightName"];
		echo $row["Destination"];
		echo $row["DepartureDate"];
		echo $row["ReturnDate"];
	}
}
?>

<body>
<html>