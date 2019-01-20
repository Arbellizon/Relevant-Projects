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

    $query = "SELECT description, image_url, min_price,max_price FROM prize ";

    $To = $conDb->prepare($query);

    $To->execute();

    $data = $To->fetchAll(PDO::FETCH_ASSOC);

    $toSend = $data;

    echo json_encode($toSend);

  
/*
    foreach($data as $row)
    {
        $row['']
    }
    */
?>