//Interfaces y clases Abstractas


using InterfacesClasesAbs;

var koopaRojo = new RedKoopa(4);
var koopaRojoCreado = koopaRojo.CrearKoopa();
var koopaRojoAccion = koopaRojo.ShellAction("Red");
var koopaRojoVuela = koopaRojo.Fly();


Console.WriteLine($"{koopaRojoCreado} y {koopaRojoAccion} y {koopaRojoVuela}");


var koopaAzul = new BlueKoopa(4);
var koopaAzulCreado = koopaAzul.CrearKoopa();
var koopaAzulAccion = koopaAzul.ShellAction("Red");
var koopaAzulNada = koopaAzul.Swim();


Console.WriteLine($"{koopaAzulCreado} y {koopaAzulAccion} y {koopaAzulNada}");