<Query Kind="Statements">
  <Connection>
    <ID>bd7b4622-c608-43bf-8f1d-0a2dbc928299</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-VMVCCO6\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA/3ButGEU+EKRVpfkRCkzzQAAAAACAAAAAAAQZgAAAAEAACAAAAD/CwFbpWqXRfO9IXBWZ4yeKCjJ05YroDeKDHKmlSw5ZAAAAAAOgAAAAAIAACAAAAAp7uzNt3geQp9t3YVzOEuw/aVRxIO42eaIBt3rAQrWkBAAAADHKFfu3cqL7HWc7KQ49IAZQAAAACqKub2l85uDLm/OACs/H6u1/8ZQ2QqS7u9fCAAPNjO63DqeQ/Khvuh+x2GRwirTNKoaHEXF7Qq19ZbGL15ZYfo=</Password>
    <Database>Bootcamps2020</Database>
  </Connection>
</Query>

//first
var f = TBL_EMPLOYEES.First(t=>t.EMP_ID==101);
Console.WriteLine(f);

//First or default
var a = TBL_EMPLOYEES.FirstOrDefault(t=>t.EMP_ID==100);
Console.WriteLine(a);