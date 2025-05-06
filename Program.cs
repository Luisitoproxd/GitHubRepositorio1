using System.Collections;
//defincion e inicialización de los arreglos en paralelo y el diccionario
String[] Departamento = {"Boaco","Carazo","Chinandega","Chontales","Costa Caribe Norte","Costa Caribe Sur","Estelf","Granada","Jinotega","León","Madriz","Managua","Masaya","Matagalpa","Nueva Segovia","Rio San、Juan","Rivas"}; 
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645};
Dictionary<string, int> diccionario = Departamento
.Zip(Poblacion, (k, v)=> new {Clave = k, Valor = v})
.ToDictionary (x => x.Clave, x => x.Valor);
//fijando los nombres de los departamen tos con menor y mayor poblacion
string minDepkey = ordenado. First () .Key;
string maxDepkey= ordenado. Last ().Key;
//Mostrar los arreglos ordenados de menor a mayor.
for (var i= 0; i< Poblacion. Length; i++)
Console.WriteLine ($"{Departamento [i],20} ==> {Poblacion [i],10:N0}");
 //Mostrar el diccionario sin ordenar 
Console.WriteLine ($"Datos Desordenados");
foreach (var item in diccionario){
    Console.WriteLine ($"{item.Key,-20}==>{item.Value,10:N0}");
}
Console.WriteLine (); 
//Sumar todas las poblaciones con SUM de LINQ
Console.WriteLine ($" Población General:{Poblacion. Sum():N0}");
Console.WriteLine ($"Depto. con mayor Población:{maxDepkey}");
Console.WriteLine ($"Depto. con menor Población:{minDepkey}");
//Poblacion promedio
Console.WriteLine($"Población promedio: {diccionario.Values.Average():N2}");
