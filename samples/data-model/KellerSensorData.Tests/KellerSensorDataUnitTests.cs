using System;
using KellerSensorDataExchange;
using Xunit;

namespace KellerSensorData.Tests;

public class KellerSensorDataUnitTests
{
    private const string ExampleJsonData = "{\"version\":\"1.0.0\",\"header\":{\"compensatedPressureRange\":{\"max\":0.35,\"min\":0.0,\"unit\":\"bar\"},\"compensatedTemperatureRange\":{\"max\":80.0,\"min\":-10.0,\"unit\":\"�C\"},\"creationDate\":\"2022-03-17\",\"customerName\":\"DemoData Inc.\",\"customerNumber\":12345678,\"customerOrderNumber\":\"Cust-9990266-123\",\"customerProductType\":\"123021-1804\",\"customerReferenceNumber\":\"\",\"electricSupply\":{\"magnitude\":1.0,\"unit\":\"mA\"},\"orderNumber\":9990266,\"orderPosition\":1,\"orderTargetDispatchDate\":\"2022-03-31\",\"pressureType\":\"PAA\",\"productNumber\":\"123021.1804\",\"productSeries\":\"9L\",\"productType\":\"PAA-9L / 0,35bar MM0123 / 03-00006-02\",\"remarks\":\"\",\"serialNumber\":\"43345\"},\"compensationMethods\":{\"mathematicalModels\":{\"MM0123\":{\"compensatedPressureRange\":{\"max\":0.35,\"min\":0.0,\"unit\":\"bar\"},\"compensatedTemperatureRange\":{\"max\":80.0,\"min\":-10.0,\"unit\":\"�C\"},\"electricSupply\":{\"magnitude\":1.0,\"unit\":\"mA\"},\"modelType\":\"MM0123\",\"parts\":{\"pressure\":{\"coefficients\":[[1.85692868408,-0.00176274170225,6.08504105681E-07,-9.46199708063E-11,5.48501841122E-15],[-0.0972484450016,0.000104619893035,-3.93932586974E-08,6.58963486505E-12,-4.14190897641E-16],[-0.000373683194975,4.27054468987E-07,-1.80529385661E-10,3.36350195079E-14,-2.33638757066E-18]],\"description\":\"P = f(Sig,R)\",\"inputs\":[\"Sig\",\"R\"],\"output\":\"P\"},\"temperature\":{\"coefficients\":[[-7875.18668483,4.71681063908,-0.0366221497503],[7.75947043698,-0.00381835738619,3.48767690506E-05],[-0.0029340260666,1.08338912161E-06,-1.22673564817E-08],[5.02759289993E-07,-1.16986520147E-10,1.87879778498E-12],[-3.25143822494E-11,2.92124562593E-15,-1.04990231291E-16]],\"description\":\"T = f(R,Sig)\",\"inputs\":[\"R\",\"Sig\"],\"output\":\"T\"}},\"productNumber\":\"000000.0000\"}}},\"measurements\":[{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0032549803,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.0300203,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.10447821,\"unit\":\"�C\"},\"output\":{\"magnitude\":-10.8285,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0300089,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.724,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":16.835300087,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3279.5481718,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.010635471,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109973,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.10540903,\"unit\":\"�C\"},\"output\":{\"magnitude\":-10.8294,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.11001,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.724,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":28.717313749,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3275.0864314,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0013791776,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.190012,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.10956359,\"unit\":\"�C\"},\"output\":{\"magnitude\":-10.8336,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.190007,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.724,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":40.561959915,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3270.7050805,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0089804813,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.27004,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.10242714,\"unit\":\"�C\"},\"output\":{\"magnitude\":-10.8264,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.270009,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.724,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":52.35529052,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3266.5112946,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0021524411,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.350001,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.11231611,\"unit\":\"�C\"},\"output\":{\"magnitude\":-10.8353,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.350009,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.724,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-10.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":64.089227672,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3262.3277696,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.00678067,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.0300302,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.12024807,\"unit\":\"�C\"},\"output\":{\"magnitude\":-0.762943,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0300065,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-0.642695,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":0.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":17.295930405,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3349.845663,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0083823212,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109974,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.12160132,\"unit\":\"�C\"},\"output\":{\"magnitude\":-0.764297,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.110003,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-0.642695,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":0.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":29.145039023,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3345.4044402,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.00072080431,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.190012,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.12460121,\"unit\":\"�C\"},\"output\":{\"magnitude\":-0.767296,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.190009,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-0.642695,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":0.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":40.959807007,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3341.0362687,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0077373784,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.270028,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.12879956,\"unit\":\"�C\"},\"output\":{\"magnitude\":-0.771495,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.270001,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-0.642695,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":0.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":52.723112607,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3336.7535714,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0071183762,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.349969,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.12835942,\"unit\":\"�C\"},\"output\":{\"magnitude\":-0.771055,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.349994,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":-0.642695,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":0.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":64.427321444,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3332.6041261,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0020968317,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.0300026,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.0038519228,\"unit\":\"�C\"},\"output\":{\"magnitude\":19.5496,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0299953,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":19.5458,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":20.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":18.276150504,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3507.8958356,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.010376327,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109963,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.0022601434,\"unit\":\"�C\"},\"output\":{\"magnitude\":19.5435,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.109999,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":19.5458,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":20.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":30.11957974,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3503.411633,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":4.6754682E-05,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.189998,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.0050829148,\"unit\":\"�C\"},\"output\":{\"magnitude\":19.5407,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.189998,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":19.5458,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":20.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":41.930923254,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3499.0245959,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.01003113,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.270032,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.0065285246,\"unit\":\"�C\"},\"output\":{\"magnitude\":19.5392,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.269997,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":19.5458,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":20.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":53.698635194,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3494.7234541,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0018963045,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.35,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.015296378,\"unit\":\"�C\"},\"output\":{\"magnitude\":19.5305,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.350007,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":19.5458,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":20.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":65.412835065,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3490.4398085,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0057068157,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.0300204,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.010535843,\"unit\":\"�C\"},\"output\":{\"magnitude\":39.7089,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0300004,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":39.7193,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":40.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":19.327300019,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3684.4714057,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0072598586,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109965,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.013266701,\"unit\":\"�C\"},\"output\":{\"magnitude\":39.7061,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.10999,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":39.7193,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":40.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":31.223094874,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3679.9504891,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.00028980046,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.190011,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.01387313,\"unit\":\"�C\"},\"output\":{\"magnitude\":39.7055,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.19001,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":39.7193,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":40.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":43.095836095,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3675.5244906,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0071607438,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.27003,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.013508622,\"unit\":\"�C\"},\"output\":{\"magnitude\":39.7058,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.270005,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":39.7193,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":40.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":54.926217197,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3671.1898308,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0058118933,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.349983,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":-0.014741985,\"unit\":\"�C\"},\"output\":{\"magnitude\":39.7046,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.350003,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":39.7193,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":40.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":66.708383272,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3666.9207459,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0047034311,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.0300207,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.067052707,\"unit\":\"�C\"},\"output\":{\"magnitude\":59.9287,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0300042,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":59.8616,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":60.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":20.448307577,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3877.530465,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.011316331,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109956,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.069932854,\"unit\":\"�C\"},\"output\":{\"magnitude\":59.9316,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.109996,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":59.8616,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":60.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":32.438664116,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3872.9670213,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0022191705,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.190018,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.068050897,\"unit\":\"�C\"},\"output\":{\"magnitude\":59.9297,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.19001,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":59.8616,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":60.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":44.413460011,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3868.442351,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0082062642,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.270032,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.073491641,\"unit\":\"�C\"},\"output\":{\"magnitude\":59.9351,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.270003,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":59.8616,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":60.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":56.347647221,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3864.0853163,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.0036316716,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.349982,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.072408236,\"unit\":\"�C\"},\"output\":{\"magnitude\":59.934,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.349995,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":59.8616,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":60.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":68.238012974,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":3859.7589154,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0045557936,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.030011,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.09407806,\"unit\":\"�C\"},\"output\":{\"magnitude\":80.0403,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.0299951,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":79.9462,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.03,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":80.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":21.679262085,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":4085.9092492,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.01175685,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.109958,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.10048904,\"unit\":\"�C\"},\"output\":{\"magnitude\":80.0467,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.109999,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":79.9462,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.11,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":80.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":33.797802852,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":4081.3042489,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0021202018,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.190013,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.10352433,\"unit\":\"�C\"},\"output\":{\"magnitude\":80.0497,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.190006,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":79.9462,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.19,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":80.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":45.90352679,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":4076.7266035,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":0.0089590218,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.27004,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.112308,\"unit\":\"�C\"},\"output\":{\"magnitude\":80.0585,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.270009,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":79.9462,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.27,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":80.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":57.976136661,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":4072.2874904,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"},{\"compensated\":{\"mathematicalModels\":{\"MM0123\":{\"pressure\":{\"error\":{\"magnitude\":-0.004961936,\"unit\":\"%FS\"},\"output\":{\"magnitude\":0.34999,\"unit\":\"bar\"}},\"temperature\":{\"error\":{\"magnitude\":0.11687622,\"unit\":\"�C\"},\"output\":{\"magnitude\":80.0631,\"unit\":\"�C\"}}}}},\"environment\":{\"pressure\":{\"magnitude\":0.350007,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":79.9462,\"unit\":\"�C\"},\"supply\":{\"magnitude\":1.0,\"unit\":\"mA\"}},\"environmentTarget\":{\"pressure\":{\"magnitude\":0.35,\"unit\":\"bar\"},\"temperature\":{\"magnitude\":80.0,\"unit\":\"�C\"}},\"raw\":{\"signal\":{\"magnitude\":70.007292791,\"unit\":\"mV\"},\"bridgeResistance\":{\"magnitude\":4067.8936654,\"unit\":\"Ohm\"}},\"reference\":\"F_16000_XX_0000007445\"}]}";

    [Fact]
    public void Deserialize_Json_correctly()
    {
        KellerSensorDataExchange.KellerSensorData kellerSensorData = KellerSensorDataExchange.KellerSensorData.FromJson(ExampleJsonData);

        Assert.NotNull(kellerSensorData);
        Assert.Equal(kellerSensorData.Version, "1.0.0");
        Assert.Equal(kellerSensorData.Header.CustomerNumber, 12345678);
        Assert.Equal(kellerSensorData.Header.CreationDate, new DateTime(2022, 03, 17, 0, 0, 0, DateTimeKind.Utc)); //2022-03-17
    }

    [Fact]
    public void Serialize_Json_without_exception()
    {
        KellerSensorDataExchange.KellerSensorData kellerSensorData = KellerSensorDataExchange.KellerSensorData.FromJson(ExampleJsonData);

        var exception = Record.Exception(() =>
        {
            var x = kellerSensorData.ToJson();
        });

        Assert.Null(exception);
    }
}