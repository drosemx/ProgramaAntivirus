using System;
using System.Collections;
using System.IO;

namespace ClaseMotorBusqueda
{
    class motordebusqueda
    {
             //Definición estructura de la Clase
             #region Definición Clase
             
                 #region In=Memory State
                      string _nombre;  
                         int _resultado;
                #endregion

                 #region Constructors
                    public motordebusqueda()
                    {
                            _nombre = string.Empty;
                         _resultado = int.MinValue;
                    }
                #endregion

                 #region Accesors
                    public string Nombre
                    {
                       set { _nombre = value; }
                    }
                    public int Resultado
                    {
                        get { return (_resultado); }
                        set { _resultado = value; }
                    }
                #endregion

                 #region Behavior  
                //    public void SetInfo( string _nombre, int _resultado)
                //    {
                //        _nombre = _nombre; 
                //        Resultado= _resultado;
                //    }
                #endregion

             #endregion

             //Definicion de método
             #region Metodo I busqueda por selección archivo
             
                   public  int BuscarArchivo(string NombreArchivo)
                   {
                       Resultado = 0;
                          Nombre = NombreArchivo;

                        #region Creación arreglos en memoria para los datos de los archivos
                                      ArrayList arrText = new ArrayList();
                                     ArrayList arrText2 = new ArrayList();
                        #endregion

                        #region Abrimos y leemos el archivo seleccionado y llenamos el arreglo en memoria
                                StreamReader objReader = new StreamReader(this._nombre);
                                string sLine = "";
                                while (sLine != null)
                                {
                                         sLine = objReader.ReadLine();
                                    if (sLine != null)
                                        arrText.Add(sLine);
                                }
                                objReader.Close();
                        #endregion    
                        
                        #region Abrimos y leemos Diccionario virus y llena el arreglo en memoria
                                StreamReader objReader2 = new StreamReader("diccionario de virus2.txt");
                                string sLine2 = "";
                                while (sLine2 != null)
                                {
                                         sLine2 = objReader2.ReadLine();
                                    if (sLine2 != null)
                                        arrText2.Add(sLine2);
                                }
                                objReader2.Close();
                        #endregion
               
                        #region Compara tramas para encontrar coincidencias en ambos archivos
                            foreach (string sOutput2 in arrText2)
                            {
                                foreach (string sOutput in arrText)
                                {
                                    if (sOutput2.ToString().Trim() == sOutput.ToString())
                                        Resultado = Resultado + 1;
                                }
                            }
                        #endregion
                            
                        #region Envio de resultado
                            return Resultado;
                        #endregion
                    }
             #endregion
        

    }
}
