double faturamentoSp = 67836.43;
double faturamentoRj = 36678.66;
double faturamentoMg = 29229.88;
double faturamentoEs = 27165.48;
double faturamentoOutros = 19849.53;

double faturamentoTotal = faturamentoSp + faturamentoRj + faturamentoMg + faturamentoEs + faturamentoOutros;

Console.WriteLine($"Faturamento total = {faturamentoTotal.ToString("F2")}");
Console.Write("Faturamento SP: ");
PercentualFaturamento(faturamentoSp, faturamentoTotal);
Console.Write("Faturamento RJ: ");
PercentualFaturamento(faturamentoRj, faturamentoTotal);
Console.Write("Faturamento MG: ");
PercentualFaturamento(faturamentoMg, faturamentoTotal);
Console.Write("Faturamento Es: ");
PercentualFaturamento(faturamentoEs, faturamentoTotal);
Console.Write("Faturamento Outros: ");
PercentualFaturamento(faturamentoOutros, faturamentoTotal);


static void PercentualFaturamento(double faturamentoEstado, double faturamentoTotal)
{
    Console.WriteLine((faturamentoEstado / faturamentoTotal * 100).ToString("F4") + "%");
}