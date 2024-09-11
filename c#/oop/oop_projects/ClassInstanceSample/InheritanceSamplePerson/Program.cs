// See https://aka.ms/new-console-template for more information

using InheritanceSamplePerson;

Account accounPersonel = new Account();
accounPersonel.AdSoyad = "John Doe";
accounPersonel.DogumTarihi = DateTime.Now.AddYears(-35).AddDays(-25);
accounPersonel.Cinsiyet = true;
accounPersonel.Kilo = 85;
accounPersonel.Boy = 180;
accounPersonel.EhliyetVarMi = false;
accounPersonel.SaglikSorunuVarMi = false;
accounPersonel.AldigiUcret = 75000;
accounPersonel.MaasBilgileriniGorebilir = true;
accounPersonel.MaasBilgileriniDegistirebilir = true;
accounPersonel.BilgileriGoster();

Console.WriteLine(new string('*', 100));

HumanResources humanResources = new HumanResources("Jeyn Doe", DateTime.Now.AddYears(-30).AddMonths(-2), false, 70, 170, true, false, 85000, true, false, true);

