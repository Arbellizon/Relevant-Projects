<?php
session_start();
ob_start();
?>

<html>
<body>

<form action= "CustomerReg.php" method="POST">
First Name: <input type="text" name="Fname">
<br>
Last Name: <input type="text" name="Lname">
<br>
Phone: <input type="text" name="Phone">
<br>
Email: <input type="text" name="Email">
<br>
Billing Address: <input type="text" name="Badd">
<br>
Mailing Address: <input type="text" name="Madd">
<br>
Username: <input type="text" name="Username">
<br>
Password: <input type="text" name="Password">

<input type="Submit" name="Submitbutton" value="Login">

</form>
<?php
if(isset($_POST["Submitbutton"]))
{
	$Username=$_POST["Username"];
	$Password= $_POST["Password"];
	$FirstName= $_POST["Fname"];
	$LastName= $_POST["Lname"];
	$Phone= $_POST["Phone"];
	$Email= $_POST["Email"];
	$MailingAddress= $_POST["Madd"];
	$BillingAddress= $_POST["Badd"];
	$conn=mysql_connect("thor.quincy.edu","csc320_calvija","abc");
if(!$conn)
{ 
	die("Unable to connect to Database selected !");
}
mysql_select_db("csc320_calvija", $conn);
$Insert_query="Insert into Customers Values('','$FirstName','$LastName','$Phone','$Email','$MailingAddress','$BillingAddress','$Username','$Password');";
echo $Insert_query;
$results=mysql_query($Insert_query, $conn);
	if(mysql_affected_rows("$Insert_query")==-1)
	{ 
		die ("Failed Registration");
	}

	else
	{
		
		header("Location:index.php");	
	}
	}
		
?>
</body>
</html>