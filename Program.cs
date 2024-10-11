
using System.Text;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Poder Volar";
poderVolar.Descripcion = "El poder de volar, surcar y planear en los cielos";
poderVolar.Nivel = NivelPoder.NivelUno;


var poderComer = new SuperPoder();
poderComer.Nombre = "Poder Comer";
poderComer.Descripcion = "Capacidad de transformar la gente en comida";
poderComer.Nivel = NivelPoder.NivelUno;


var lanzarTelarañas = new SuperPoder();
lanzarTelarañas.Nombre = "Telarañas";
lanzarTelarañas.Descripcion = "Capacidad de lazar telarañas por las manos a voluntad";
lanzarTelarañas.Nivel = NivelPoder.NivelTres;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var  majinbu = new SuperHeroe();
majinbu.Id = 3;
majinbu.Nombre = "majinbu";
majinbu.IdentidadSecreta = "nino gordo";
majinbu.PuedeVolar = true;

List<SuperPoder >podermajinbu = new List<SuperPoder>();
podermajinbu.Add(poderComer);


var hombreAraña = new SuperHeroe();
hombreAraña.Id = 2;
hombreAraña.Nombre = "El Hombre Araña";
hombreAraña.IdentidadSecreta = "Petter Parcker";
hombreAraña.PuedeVolar = false;

List<SuperPoder> poderesAraña = new List<SuperPoder>();
poderesAraña.Add(lanzarTelarañas);
poderesAraña.Add(superFuerza);


var superMAn = new SuperHeroe();
superMAn.Id = 1;
superMAn.Nombre = "Super Man";
superMAn.IdentidadSecreta = "Clarck kent";
superMAn.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superMAn.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superMAn.UsarSuperPoder();
Console.WriteLine(resultSuperPoderes);


class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;

    } 

    public string UsarSuperPoder()
    {
        StringBuilder sb  = new StringBuilder();
        foreach (var item in SuperPoderes)
        {
            sb.AppendLine($"El super heroe {Nombre} esta usando el super poder {item.Nombre}");
        }
        return sb.ToString();
    }

}
class SuperPoder
{
    public string Nombre;
    public string Descripcion;

    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;

    }

}

enum NivelPoder
{
    NivelUno, NivelDos, NivelTres
}