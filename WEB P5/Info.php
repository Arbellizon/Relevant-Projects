<?php

$User ="csc390_fa18_calv@localhost";

$Pass ="nbFWbzdgeRuYeFt7";
$Db = 'mysql:dbname=csc390_fa18_calv;host=localhost';

    try
    {
        $conDb = new PDO($Db,$User,$Pass);
        $conDb->setattribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    } 
    catch(PDOExeception $e)
    {
        die('Connection Failed: '. $e->getMessage());
    }

    $query = "SELECT*FROM prize";

    $To = $conDb->prepare($query);

    $To->execute();

    $data = $To->fetchAll();

    var_dump($data);
/*
    foreach($data as $row)
    {
        $row['']
    }
    */
?>