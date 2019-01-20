

<?php
session_start();
?>

<?php

if(isset ( $_SESSION['counter']))
{
	$_SESSION['counter'] +=1;
}
else
{
	$_SESSION['counter']=1;
}
$Session_message= " Time to make your registration".$_SESSION['counter'];
<br>
$Session_message.=" Get ready.";

echo ($Session_message);

?>

<p>
To continue click the link to continue
<br/>
 <a href = "Menue.php?<?php echo htmlspecialchars(SID);?>">
 <br/>
</p>
