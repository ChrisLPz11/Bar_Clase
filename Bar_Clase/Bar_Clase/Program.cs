using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BarDbEntities db = new BarDbEntities())

            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                    int num = 0;
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("               Sean Bienvenidos a EL Bar BIG BOSS\n        ");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("                         Seleccione una opcion                        ");
                Console.WriteLine("                         1.Insertar Producto");
                Console.WriteLine("                         2.Eliminar Producto");
                Console.WriteLine("                         3.Actualizar Producto");
                Console.WriteLine("                         4.Mostrar Producto");
                Console.WriteLine("                               5.Cerra");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------");
                switch (num)
                    {
                    case 1:
                        {
                            
                            Producto oProducto = new Producto();
                            Console.WriteLine("Ingrese  Nombre");
                            oProducto.nomProd = Console.ReadLine();
                            Console.WriteLine("Ingrese una Descripcion");
                            oProducto.descripcion = Console.ReadLine();
                            Console.WriteLine("Ingrese  el Precio");
                            oProducto.precio = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese la Cantidad");
                            oProducto.cantidad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese un Estado");
                            oProducto.estado = Convert.ToInt32(Console.ReadLine());

                            db.Producto.Add(oProducto);
                            db.SaveChanges();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Producto oProducto = new Producto();
                            Console.WriteLine("Ingrese EL id Para Eliminar");
                            oProducto.idProducto = Convert.ToInt32(Console.ReadLine());
                            db.Entry(oProducto).State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            break;
                        }
                    case 3:
                        {
                            Producto oProducto = new Producto();
                            Console.WriteLine("Seleccione el id Para Actualizar");
                            oProducto.idProducto = Convert.ToInt32(Console.ReadLine());
                            db.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Productos del Bar");
                            var lista = db.Producto;
                            foreach(var Producto in lista)
                            {
                                Console.WriteLine("{0},{1},{2},{3},{4},{5}",Producto.idProducto,Producto.nomProd,Producto.descripcion,Producto.precio,Producto.cantidad,Producto.estado);
                                Console.ReadLine();
                            }




                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }

                }

                


                
            }
        }
    }
}