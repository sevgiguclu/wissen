// See https://aka.ms/new-console-template for more information

using KurumsalMimari;

//int dbTYpe = 1;

//if (dbTYpe == 1)
//{
//    MSSQLOperations sqlServer = new MSSQLOperations();
//    sqlServer.Insert();
//    sqlServer.Update();
//    sqlServer.Delete();
//    sqlServer.Read();
//}
//else if (dbTYpe == 2)
//{
//    OracleOperations oracleServer = new OracleOperations();
//    oracleServer.Insert();
//    oracleServer.Update();
//    oracleServer.Delete();
//    oracleServer.Read();
//}


//yukarıdaki gibi if else yapmak yerine (çok fazla çeşit olabilir) bir manager sınıfı oluşturduk ve içine paremtre alan bir constructor tanımladık 
DbOperationsManager dbOpSQL = new DbOperationsManager(new MSSQLOperations());
dbOpSQL.Insert();
dbOpSQL.Update();

Console.WriteLine(new string('-', 100));

DbOperationsManager dbOPOracle = new DbOperationsManager(new OracleOperations());
dbOPOracle.Insert();
dbOPOracle.Update();
dbOPOracle.Read();
dbOPOracle.Delete();
