using Proyecto_Final_BD.Entides;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD.Datos
{
    public class ClsProcedimientos
    {
        //LAS MÉTODOS, CLASES DE SQL Y COMANDOS DE SQL QUE SE UTILIZARON EN LOS PROCEDIMIENTOS DE LA TABLA TORNEO SE APLICARAN A TODOS, POR LO TANTO NO VAKOS A SEGUIR DOCUMENTANDO
        //CABE RECALCAR QUE: A LA HORA DE HACER LAS CONSULTAS EN SQL SERVER TENDRÁ QUE APLICAR BBUENAS PRACTICAS Y HACERLAS EN MAYÚSCULAS SOSTENIDAS
        //Cracion de procedimiento para guardar los datos de la tabal torneo
        public static int GuardarTorneo(ClsTorneo ObjetoComando)
        {
            int Estado = 1;
            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("SP_Registro_Datos_TORNEOS", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Nombre_Torneo", ObjetoComando.Nombre_torneo);
                Comando.Parameters.AddWithValue("@Categoria", ObjetoComando.Categoria);
                Comando.Parameters.AddWithValue("@Fecha_Inicio", ObjetoComando.Fecha_Inicio);
                Comando.Parameters.AddWithValue("@Fecha_Final", ObjetoComando.Fecha_Final);
                Comando.Parameters.AddWithValue("@Ubicacion_T", ObjetoComando.Ubicacion_T);
                Comando.Parameters.AddWithValue("@Reglas_Especificas", ObjetoComando.Reglas_Especificas);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                Comando.Parameters.AddWithValue("@Id_Torneo", ObjetoComando.Id_Torneo);

                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }

        //Creamos una lista para mostrar en nuestro data view todos los datos que ingresemos
        public static List<ClsTorneo> PresentarRegistroTorneo()
        {
            List<ClsTorneo> Lista = new List<ClsTorneo>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM TORNEOS"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsTorneo torneo = new ClsTorneo();

                    torneo.Id_Torneo = Reader.GetInt32(0);
                    torneo.Nombre_torneo = Reader.GetString(1);
                    torneo.Categoria = Reader.GetString(2);
                    torneo.Fecha_Inicio = Reader.GetDateTime(3);
                    torneo.Fecha_Final = Reader.GetDateTime(4);
                    torneo.Ubicacion_T = Reader.GetString(5);
                    torneo.Reglas_Especificas = Reader.GetString(6);
                    torneo.Estado = Reader.GetBoolean(7);
                    Lista.Add(torneo);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        //Procedimeinto para poder modificar los datos ingresados ne Torneo
        public static int ModificarTorneo(ClsTorneo torneo) //Objeto 
        {
            int Estado = 1;
            //Variables para resultados 0 y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("Sp_Modificar_Datos_Torneo", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Nombre_Torneo", torneo.Nombre_torneo);
                Comando.Parameters.AddWithValue("@Categoria", torneo.Categoria);
                Comando.Parameters.AddWithValue("@Fecha_Inicio", torneo.Fecha_Inicio);
                Comando.Parameters.AddWithValue("@Fecha_Final", torneo.Fecha_Final);
                Comando.Parameters.AddWithValue("@Ubicacion_T", torneo.Ubicacion_T);
                Comando.Parameters.AddWithValue("@Reglas_Especificas", torneo.Reglas_Especificas);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                Comando.Parameters.AddWithValue("@Id_Torneo", torneo.Id_Torneo);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }
        public static int EliminarTorneo(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM TORNEOS WHERE id_Torneo= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarJugador(ClsRegistroJugador Jugador, string id_Equipo) //Ingresamos objeto de la clase Registro_Jugador
        {
            int Estado = 1;
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand("SP_Registro_Datos_Jugadores", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@id_Equipo", id_Equipo);
                Comando.Parameters.AddWithValue("@Nombre", Jugador.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", Jugador.Apellido);
                Comando.Parameters.AddWithValue("@Documento", Jugador.Documento);
                Comando.Parameters.AddWithValue("@Edad", Jugador.Edad);
                Comando.Parameters.AddWithValue("@Genero", Jugador.Genero);
                Comando.Parameters.AddWithValue("@Telefono", Jugador.Telefono);
                Comando.Parameters.AddWithValue("@Correo", Jugador.Correo);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                //Comando.Parameters.AddWithValue("@id_Jugador", Jugador);

                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }
        public static List<ClsRegistroJugador> PresentarRegistroJugador()
        {
            List<ClsRegistroJugador> Lista = new List<ClsRegistroJugador>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM REGISTRO_JUGADOR"; //Variable no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Jugador + sus atributos
                    ClsRegistroJugador Jugador = new ClsRegistroJugador();

                    Jugador.id_Jugador = Reader.GetInt32(0);
                    Jugador.id_Equipo = Reader.GetInt32(1);
                    Jugador.Nombre = Reader.GetString(2);
                    Jugador.Apellido = Reader.GetString(3);
                    Jugador.Documento = Reader.GetString(4);
                    Jugador.Edad = Reader.GetInt32(5);
                    Jugador.Genero = Reader.GetString(6);
                    Jugador.Telefono = Reader.GetString(7);
                    Jugador.Correo = Reader.GetString(8);
                    Jugador.Estado = Reader.GetBoolean(9);
                    Lista.Add(Jugador);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int ModificarRegistroJugador(ClsRegistroJugador Jugador, string id_Equipo) //Objeto 
        {
            int Estado = 1;
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {


                SqlCommand Comando = new SqlCommand("SP_Modificar_Datos_Jugador", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@id_Equipo", id_Equipo);
                Comando.Parameters.AddWithValue("@Nombre", Jugador.Nombre);
                Comando.Parameters.AddWithValue("@Apellido", Jugador.Apellido);
                Comando.Parameters.AddWithValue("@Documento", Jugador.Documento);
                Comando.Parameters.AddWithValue("@Edad", Jugador.Edad);
                Comando.Parameters.AddWithValue("@Genero", Jugador.Genero);
                Comando.Parameters.AddWithValue("@Telefono", Jugador.Telefono);
                Comando.Parameters.AddWithValue("@Correo", Jugador.Correo);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                Comando.Parameters.AddWithValue("@id_Jugador", Jugador.id_Jugador);



                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarRegistroJugador(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM REGISTRO_JUGADOR WHERE id_Jugador = " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarEquipo(ClsRegistroEquipo Equipo, string id_torneo)
        {
            int Estado = 1;
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y en su defecto nuestra base de datos por medio del comando SqlConnection
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand("SP_Registro_Datos_Equipos", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@id_Torneo", id_torneo);
                Comando.Parameters.AddWithValue("@Nombre", Equipo.Nombre);
                Comando.Parameters.AddWithValue("@Categoria", Equipo.Categoria);
                Comando.Parameters.AddWithValue("@Cantidad_Jugadores", Equipo.Cantidad_Jugadores);
                Comando.Parameters.AddWithValue("@Patrocinadores", Equipo.Patrocinadores);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                Comando.Parameters.AddWithValue("@id_Equipo", Equipo.id_Equipo);

                try
                {
                    //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                    Retorna = Comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Imprimimos el mensaje de error
                    Console.WriteLine("Error al insertar en la tabla REGISTRO_EQUIPOS: " + ex.Message);
                }
            }
            return Retorna;
        }

        public static List<ClsRegistroEquipo> PresentarRegistroEquipo()
        {
            List<ClsRegistroEquipo> Lista = new List<ClsRegistroEquipo>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM REGISTRO_EQUIPOS"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Registro_Equipo + sus atributos
                    ClsRegistroEquipo Equipo = new ClsRegistroEquipo();

                    Equipo.id_Equipo = Reader.GetInt32(0);
                    Equipo.id_Torneo = Reader.GetInt32(1);
                    Equipo.Nombre = Reader.GetString(2);
                    Equipo.Categoria = Reader.GetString(3);
                    Equipo.Cantidad_Jugadores = Reader.GetInt32(4);
                    Equipo.Patrocinadores = Reader.GetString(5);
                    Equipo.Estado = Reader.GetBoolean(6);
                    Lista.Add(Equipo);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int ModificarRegistroEquipo(ClsRegistroEquipo Equipo, string id_Torneo) //Objeto 
        {
            int Estado = 1;
            //Variables para resultados 0 y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("SP_Registro_Datos_Equipos", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@id_Torneo", id_Torneo);
                Comando.Parameters.AddWithValue("@Nombre", Equipo.Nombre);
                Comando.Parameters.AddWithValue("@Categoria", Equipo.Categoria);
                Comando.Parameters.AddWithValue("@Cantidad_Jugadores", Equipo.Cantidad_Jugadores);
                Comando.Parameters.AddWithValue("@Patrocinadores", Equipo.Patrocinadores);
                Comando.Parameters.AddWithValue("@Estado", Estado);
                Comando.Parameters.AddWithValue("@id_Equipo", Equipo.id_Equipo);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarEquipo(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM REGISTRO_EQUIPOS WHERE id_Equipo= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }
        public static int GuardarProgramacion(ClsProgramacion Programacion, string id_Torneo, string Equipo_local, string Equipo_visitante)
        {
            int Estado = 1;
            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("SP_REGISTRO_DATOS_PROGRAMACION", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Id_Torneo", id_Torneo);
                Comando.Parameters.AddWithValue("@Fecha", Programacion.Fecha);
                Comando.Parameters.AddWithValue("@Hora", Programacion.Hora);
                Comando.Parameters.AddWithValue("@Ubicacion", Programacion.Ubicacion);
                Comando.Parameters.AddWithValue("@Equipo_Local", Equipo_local);
                Comando.Parameters.AddWithValue("@Equipo_Visitante", Equipo_visitante);
                Comando.Parameters.AddWithValue("@Estado", Estado);

                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }

        public static List<ClsProgramacion> PresentarRegistroProgramacion()
        {
            List<ClsProgramacion> Lista = new List<ClsProgramacion>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM PROGRAMACION"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Registro_Programacion + sus atributos
                    ClsProgramacion Programacion = new ClsProgramacion();

                    Programacion.id_Programacion = Reader.GetInt32(0);
                    Programacion.id_Torneo = Reader.GetInt32(1);
                    Programacion.Fecha = Reader.GetDateTime(2);
                    Programacion.Hora = Reader.GetDateTime(3);
                    Programacion.Ubicacion = Reader.GetString(4);
                    Programacion.Equipo_Local = Reader.GetString(5);
                    Programacion.Equipo_Visitante = Reader.GetString(6);
                    Programacion.Estado = Reader.GetBoolean(7);

                    Lista.Add(Programacion);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int ModificarProgramacion(ClsProgramacion Programacion, string id_Torneo, string Equipo_local, string Equipo_visitante) //Objeto 
        {
            //Variables para resultados o y 1
            int Resultados = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {

                SqlCommand Comando = new SqlCommand("SP_Modificar_Datos_Programacion", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;


                Comando.Parameters.AddWithValue("@Id_Torneo", id_Torneo);
                Comando.Parameters.AddWithValue("@Fecha", Programacion.Fecha);
                Comando.Parameters.AddWithValue("@Hora", Programacion.Hora);
                Comando.Parameters.AddWithValue("@Ubicacion", Programacion.Ubicacion);
                Comando.Parameters.AddWithValue("@Equipo_Local", Equipo_local);
                Comando.Parameters.AddWithValue("@Equipo_Visitante", Equipo_visitante);
                Comando.Parameters.AddWithValue("@id_Programacion", Programacion.id_Programacion);

                Resultados = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultados;
        }

        public static int EliminarProgramacion(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM PROGRAMACION WHERE id_Programacion= " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarResultados(ClsResultados Resultados, string id_torneo, string Equipo_local, string Equipo_visitante, string Ganador, string Perdedor, string Empate)
        {
            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {

                SqlCommand Comando = new SqlCommand("SP_REGISTRAR_DATOS_RESULTADOS", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Id_Torneo", id_torneo);
                Comando.Parameters.AddWithValue("@Equipo_Local", Equipo_local);
                Comando.Parameters.AddWithValue("@Equipo_Visitante", Equipo_visitante);
                Comando.Parameters.AddWithValue("@Marcador", Resultados.Marcador);
                Comando.Parameters.AddWithValue("@Ganador", Ganador);
                Comando.Parameters.AddWithValue("@Perdedor", Perdedor);
                Comando.Parameters.AddWithValue("@Empate", Empate);
                Comando.Parameters.AddWithValue("@Evento_Destacado", Resultados.EventoDestacado);

                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }

        public static List<ClsResultados> PresentarRegistroResultados()
        {
            List<ClsResultados> Lista = new List<ClsResultados>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM RESULTADOS"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsResultados Resultados = new ClsResultados();

                    Resultados.id_Resultado = Reader.GetInt32(0);
                    Resultados.id_Torneo = Reader.GetInt32(1);
                    Resultados.Equipo_Local = Reader.GetString(2);
                    Resultados.Equipo_Visitante = Reader.GetString(3);
                    Resultados.Marcador = Reader.GetString(4);
                    Resultados.Ganador = Reader.GetString(5);
                    Resultados.Perdedor = Reader.GetString(6);
                    Resultados.Empate = Reader.GetString(7);
                    Resultados.EventoDestacado = Reader.GetString(8);
                    Resultados.Estado = Reader.GetBoolean(9);
                    Lista.Add(Resultados);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }

        public static int ModificarResultados(ClsResultados Resultados, string id_torneo, string Equipo_local, string Equipo_visitante, string Ganador, string Perdedor, string Empate) //Objeto 
        {
       
            //Variables para resultados o y 1
            int Resultado = 0;

            //Conexion 

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("SP_Modificar_Datos_Resultados", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;


                Comando.Parameters.AddWithValue("@Id_Torneo", id_torneo);
                Comando.Parameters.AddWithValue("@Equipo_Local", Equipo_local);
                Comando.Parameters.AddWithValue("@Equipo_Visitante", Equipo_visitante);
                Comando.Parameters.AddWithValue("@Marcador", Resultados.Marcador);
                Comando.Parameters.AddWithValue("@Ganador", Ganador);
                Comando.Parameters.AddWithValue("@Perdedor", Perdedor);
                Comando.Parameters.AddWithValue("@Empate", Empate);
                Comando.Parameters.AddWithValue("@Evento_Destacado", Resultados.EventoDestacado);
                Comando.Parameters.AddWithValue("@id_Resultado", Resultados.id_Resultado);

                Resultado = Comando.ExecuteNonQuery(); //Ejecutamos 1 para exito 0 para fracaso
                Conexion.Close(); //Cerramos conexion
            }
            return Resultado;
        }
        public static int EliminarResultados(int id) //Ingresamos un int como id
        {
            int Retorna = 0;

            //Creamos la conexión con SQL SERVER y por su defecto nuestra base de datos por medio del comando SqlConnectionWHE
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                //Variable para eliminar todos los datos llamados por medio del la variable definifa
                string query = "DELETE FROM RESULTADOS WHERE id_Resultado = " + id + " ";

                //Creamos un comando de Sql que resiva nuestra variable con los datos y nuestro objeto de la clase conexion
                SqlCommand Comando = new SqlCommand(query, Conexion);

                //ExecuteNonQuery = En Sql Server, nos registra un # 1 cuando el proceso se cumple, cuando no devuelve un 0. Aplicamos eso mismo
                Retorna = Comando.ExecuteNonQuery();

            }
            return Retorna;
        }

        public static int GuardarPosiciones(ClsPosiciones posiciones, string id_Posicion, string Equipo, string Encuentros, string Victorias,
          string Derrotas, string Empates)
        {

            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                SqlCommand Comando = new SqlCommand("SP_REGISTRAR_DATOS_POSICIONES", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Equipo", Equipo);
                Comando.Parameters.AddWithValue("@Encuentros", Encuentros);
                Comando.Parameters.AddWithValue("@Victorias", Victorias);
                Comando.Parameters.AddWithValue("@Derrotas", Derrotas);
                Comando.Parameters.AddWithValue("@Empates", Empates);

                Retorna = Comando.ExecuteNonQuery();
            }
            return Retorna;
        }
        public static List<ClsPosiciones> PresentarPosiciones()
        {
            List<ClsPosiciones> Lista = new List<ClsPosiciones>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM POSICIONES"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsPosiciones posiciones = new ClsPosiciones();

                    posiciones.id_Posicion = Reader.GetInt32(0);
                    posiciones.Equipo = Reader.GetString(1);
                    posiciones.Encuentros = Reader.GetString(2);
                    posiciones.Victorias = Reader.GetString(3);
                    posiciones.Derrotas = Reader.GetString(4);
                    posiciones.Empates = Reader.GetString(5);
                    Lista.Add(posiciones);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;
            }
        }
        public static int GuardarHistorial(ClsHistorial Hitatorial, string id_Torneo, string Fecha, string Equipo_Local, string Equipo_Visitante, string Marcador, string Evento_Destacado)
        {
            string VS = "VS";
            int Retorna = 0;

            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "INSERT INTO HISTORIAL (id_Torneo, Fecha, Equipo_local, VS, Equipo_visitante, Marcador, Evento_Destacado)" +
                    "VALUES (@id_Torneo, @Fecha, @Equipo_local, @VS, @Equipo_visitaante, @Marcador, @Evento_Destacado)";

                SqlCommand Comando = new SqlCommand(query, Conexion);

                Comando.Parameters.AddWithValue("@id_Torneo", id_Torneo);
                Comando.Parameters.AddWithValue("@Fecha", Fecha);
                Comando.Parameters.AddWithValue("@Equipo_local", Equipo_Local);
                Comando.Parameters.AddWithValue("@VS", VS);
                Comando.Parameters.AddWithValue("@Equipo_visitante", Equipo_Visitante);
                Comando.Parameters.AddWithValue("@Marcador", Marcador);
                Comando.Parameters.AddWithValue("@Evento_Destacado", Evento_Destacado);

                Retorna = Comando.ExecuteNonQuery();


            }
            return Retorna;
        }
        public static List<ClsHistorial> PresentarHistorial()
        {
            List<ClsHistorial> Lista = new List<ClsHistorial>();
            //Conexion
            using (SqlConnection Conexion = ClsConexion.GetInstancia().CrearConexion())
            {
                string query = "SELECT * FROM HISTORIAL"; //Variable ya no con los datos sino con la sintaxis de una consulta general en Sql Server
                //Comando
                SqlCommand Comando = new SqlCommand(query, Conexion);
                //Comando para leer los datos
                SqlDataReader Reader = Comando.ExecuteReader();
                //Bucle que nos mostrará todos los datos ingresados en la lista
                while (Reader.Read())
                {
                    //Objeto de classe Torneo + sus atributos
                    ClsHistorial Historial = new ClsHistorial();

                    Historial.id_Historial = Reader.GetInt32(0);
                    Historial.id_Torneo = Reader.GetInt32(1);
                    Historial.Fecha = Reader.GetDateTime(2);
                    Historial.Equipo_local = Reader.GetString(3);
                    Historial.VS = Reader.GetString(4);
                    Historial.Equipo_visitante = Reader.GetString(5);
                    Historial.Marcador = Reader.GetString(6);
                    Historial.Evento_Destacado = Reader.GetString(7);
                    Lista.Add(Historial);

                }
                //Cerramos la conexion
                Conexion.Close();
                //Devolvemos la lista
                return Lista;

            }
        }
    }
}
