<Query Kind="Statements">
  <Connection>
    <ID>bd7b4622-c608-43bf-8f1d-0a2dbc928299</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-VMVCCO6\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA/3ButGEU+EKRVpfkRCkzzQAAAAACAAAAAAAQZgAAAAEAACAAAAD/CwFbpWqXRfO9IXBWZ4yeKCjJ05YroDeKDHKmlSw5ZAAAAAAOgAAAAAIAACAAAAAp7uzNt3geQp9t3YVzOEuw/aVRxIO42eaIBt3rAQrWkBAAAADHKFfu3cqL7HWc7KQ49IAZQAAAACqKub2l85uDLm/OACs/H6u1/8ZQ2QqS7u9fCAAPNjO63DqeQ/Khvuh+x2GRwirTNKoaHEXF7Qq19ZbGL15ZYfo=</Password>
    <Database>Bootcamp2020</Database>
  </Connection>
</Query>

//count
var count=TBL_EMPLOYEES.Count(t=>t.EMP_ID>108);
Console.WriteLine("total count: "+count);
//avg
var avg=TBL_EMPLOYEES.Average(t=>t.EMP_SALARY);
Console.WriteLine("total avg: "+avg);

//min

var min=TBL_EMPLOYEES.Min(t=>t.EMP_SALARY);
Console.WriteLine("total min: "+min);



// sum
var sum=TBL_EMPLOYEES.Sum(t=>t.EMP_SALARY);
Console.WriteLine("total sum: "+sum);
 //max
 var max=TBL_EMPLOYEES.Max(t=>t.EMP_SALARY);
Console.WriteLine("total max: "+max);