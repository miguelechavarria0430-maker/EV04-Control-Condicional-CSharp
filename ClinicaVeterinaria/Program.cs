
using System;

string especieMascota = "perro";
int edadMascota = 7;
double peso = 28.5;
bool tieneVacunasAlDia = false;
bool esSocio = true;
string motivoConsulta = "cirugia";

Console.WriteLine("=== Reporte de Atención Veterinaria ===");

string etapaVida = edadMascota switch
{
    < 1 => "Cachorro",
    <= 3 => "Joven",
    <= 8 => "Adulto",
    _ => "Senior"
};

Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} años | Etapa: {etapaVida}");

// Parte 2: Alerta de vacunación
string alertaVacuna;

if ((especieMascota == "perro" || especieMascota == "gato") && !tieneVacunasAlDia)
{
    alertaVacuna = "ALERTA: vacunación urgente requerida";
}
else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia)
{
    alertaVacuna = "Vacunación al día";
}
else
{
    alertaVacuna = "Esquema de vacunación no aplica";
}

Console.WriteLine($"Estado de vacunación: {alertaVacuna}");

// Parte 3: Costo base de la consulta
decimal costoBase;

switch (motivoConsulta)
{
    case "vacuna":
        costoBase = 35000m;
        break;

    case "revision":
        costoBase = 50000m;
        break;

    case "cirugia":
        costoBase = 280000m;
        break;

    case "urgencia":
        costoBase = 150000m;
        break;

    default:
        costoBase = 0m;
        break;
}
Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"))}");

// Parte 4: Descuento por membresía y peso
double porcentajeDescuento = esSocio
    ? (peso > 25 ? 15.0 : 10.0)
    : 0.0;

decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
decimal costoFinal = costoBase - descuento;
Console.WriteLine($"Descuento: {porcentajeDescuento:0}% | Costo final: ${costoFinal.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"))}");
// Parte 5: Recomendación post-consulta
string recomendacion;

if (motivoConsulta == "cirugia")
{
    if (etapaVida == "Senior")
    {
        recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
    }
    else
    {
        recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
    }
}
else if (motivoConsulta == "urgencia")
{
    if (!tieneVacunasAlDia)
    {
        recomendacion = "Atender urgencia y programar vacunación inmediata";
    }
    else
    {
        recomendacion = "Seguimiento en 48 horas";
    }
}
else
{
    recomendacion = "Seguimiento en próxima consulta de rutina";
}

Console.WriteLine($"Recomendación: {recomendacion}");
