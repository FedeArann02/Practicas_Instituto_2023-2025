using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace CRUD_EmpresaLINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            EliminaEmpleado();
        }

        public void ActualizarEmpleado()
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {
                
                EMPLEADO updEmpleadp = db.EMPLEADO.First(emp => emp.id == 1);

                updEmpleadp.Nombre = "jorgito";

                db.SaveChanges();

                ConsultaEmpleado();

            }
        }

        public void EliminaEmpleado()
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                EMPLEADO empleado = db.EMPLEADO.First(emp => emp.id == 2);

                db.EMPLEADO.Remove(empleado);

                db.SaveChanges();
                ConsultaEmpleado();
            }
        }

        public void AltaCargoEmpleado()
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                EMPLEADO empleadoJefe = db.EMPLEADO.First(emp => emp.Nombre == "Fede");
                CARGO cargoJefe = db.CARGO.First(emp => emp.NombreCargo == "Jefe");

                CARGO_EMPLEADO cargo_empleado = new CARGO_EMPLEADO() { idEmpleado = empleadoJefe.id, idCargo = cargoJefe.idCargo };

                db.CARGO_EMPLEADO.Add(cargo_empleado);
                db.SaveChanges();

                dgvPrincipal.ItemsSource = db.CARGO_EMPLEADO.Select(cargo => new { cargo.EMPLEADO.Nombre, cargo.EMPLEADO.Apellido, cargo.EMPLEADO.Correo ,cargo.CARGO.NombreCargo}).ToList();

            }
        }

        public void AltaCargos()
        {

            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                List<CARGO> cargos = new List<CARGO>()
                {
                new CARGO{ NombreCargo = "Director" },
                new CARGO{ NombreCargo = "Jefe"},
                new CARGO{ NombreCargo = "SubJefe"}
                };

                foreach (var c in cargos)
                {
                    db.CARGO.Add(c);
                }

                db.SaveChanges();

            }

        }

        public void AltaEmpresa(string Nombre)
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                EMPRESA empresa = new EMPRESA();
                bool Exist = false;

                foreach(EMPRESA emp in db.EMPRESA)
                {
                    if (emp.Nombre == Nombre)
                    {
                        Exist = true;
                        break;
                    }
                    else
                    {
                        Exist = false;
                    }
                }
                
                if (!Exist)
                {
                    empresa.Nombre = Nombre;
                    db.EMPRESA.Add(empresa);
                }
                else
                {
                    MessageBox.Show("El nombre de la empresa " + Nombre.ToUpper() + " ya existe");
                }


                db.SaveChanges();

            }
        }

        public void insertaEmpleados()
        {
            List<EMPLEADO> empleados = new List<EMPLEADO>();

            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                EMPRESA empresaMicrosoft = db.EMPRESA.First(emp => emp.Nombre == "MICROSOFT");

                empleados.Add(new EMPLEADO { Nombre = "Fede", Apellido = "Aran", Correo = "aranfederico3@gmail.com", idEmpresa = empresaMicrosoft.idEmpresa });

                foreach (EMPLEADO emp in empleados)
                {
                    db.EMPLEADO.Add(emp);
                }

                db.SaveChanges();
            }
        }

        public void BajaEmpresa(string nombre)
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {

                db.Database.ExecuteSqlCommand("delete from EMPRESA where Nombre = {0}", nombre);
                db.SaveChanges();

            }
        }

        public void ConsultaEmpleado()
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {


                dgvPrincipal.ItemsSource = db.EMPLEADO.Select(emp => new { emp.id , emp.Nombre, emp.Apellido, emp.Correo }).ToList();

                db.SaveChanges();

            }
        }

        public void ConsultaEmpresa()
        {
            using (GestionPedidosEntities db = new GestionPedidosEntities())
            {
                dgvPrincipal.ItemsSource = db.EMPRESA.Select(emp => new { emp.Nombre }).ToList();

            }
        }


    }
}
