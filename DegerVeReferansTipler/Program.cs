// int, decimal, float, double, bool-----> değer tip
// array, class, interface --------------> referans tip

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? 30  || sayi2 65

                            //   ________-> Garbage Collector burayı kontrol eder ve   
                            //   |          Burayı işaret eden birşey olmadığını farkedip bellekten kaldırır.
int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] ?? 999

