
<html>
<body>

<form action= "index.php" method= "POST">
Username: <input type= "text" name= "Username">
Password: <input type= "text" name= "Password">
<input type= "Submit" name= "Submitbutton" value= "Login">

</form>

<?php

if (isset($_POST ["Submitbutton"]))
{
	$Username= $_POST ["Username"];
	$Password= $_POST ["Password"];

	$conn=mysql_connect("thor","csc320_calvija","abc");
	if(! $conn)
	{die ("Unable to connect to DB!");}
	
	$selection=mysql_select_db("csc320_calvija",$conn);
	if(! $selection)
	{die (" No database selected ");}
	
	$loginquery="Select CustomerID From Customers Where Username='".$Username."' AND Password='".$Password."';";
		echo $loginquery;
	if(! $loginquery)
	{die (" Query failed ");}
	
	$result=mysql_query($loginquery,$conn);
	
	if(! $result)
	{echo $result;
		die ("result failed ".mysql_error());}
		
	
	if(mysql_num_rows("$result")==0)
	{ 
		echo "Failed to establish a connection";
	}
	else
	{
		$_SESSION ["username"]=$Username;
		header("Location:menu.php");
	}
	
}
?>
	</body>
	</html>