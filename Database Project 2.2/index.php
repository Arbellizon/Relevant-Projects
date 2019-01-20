  <?php
session_start();
?>

<html>
<body>

<form action= "index.php" method= "POST">
Username: <input type= "text" name= "Username">
Password: <input type= "text" name= "Password">
<br>
<input type= "Submit" name= "Submitbutton" value= "Login">

</form>



<?php 

	function_session($Username, $Default='0',$Password, $Default='0')
{
	return(isset($_SESSION[Username], $_SESSION[Password])) === True ? $_SESSION[$Username] : $Default='0', $_SESSION[$Password] : $Default='0'))
}

if (isset($_POST ["Submitbutton"]))
	{
		$_SESSION["Username"]= $_POST["Username"];
	echo $Username;
	$_SESSION["Password"]= $_POST["Password"];
	echo $Password;
	

	$conn=mysql_connect("thor","csc320_calvija","abc");
	if(! $conn)
	{
		die ("Unable to connect to DB!");
	}
	
	$selection=mysql_select_db("csc320_calvija",$conn);
	if(! $selection)
	{
		die (" No database selected ");
	}
	
	$loginquery="Select CustomerID From Customers Where Username='".$Username."' AND Password='".$Password."';";
	echo $loginquery;
		
	if(! $loginquery)
	{
		die (" Query failed ");
		echo $loginquery;
	}
	
	$result=mysql_query($loginquery,$conn);
	
	if(! $result)
	{
		echo $result;
		die ("result failed ".mysql_error());
	}
		
	if(mysql_num_rows($result)==0)
	{ 
		echo "Failed to establish a connection";
	}
	else
	{
		header("Location:Session.php");
	}
	
	}

?>
	</body>
	</html>