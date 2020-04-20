﻿namespace PointBlank.Auth
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using Files;
    using OR.Library;

    /// <summary>
    /// Classe Program
    /// </summary>
    public class Program
    {
        #region Métodos
        /// <summary>
        /// Método Main
        /// </summary>
        /// <param name="args">Parâmetro args</param>
        public static void Main()
        {
            try
            {
                // Log de inicio
                Console.Title = "Point Blank - Auth";

                // Configurações
                Logger.Info("Carregando arquivo de configurações");
                ConfigFile configFile = new ConfigFile();

                // Inicializar controles do WCF
                IBO.Network.Inicializar(configFile.CoreHost, configFile.CorePort, configFile.CoreKey);

                // Não finalizar o servidor
                Process.GetCurrentProcess().WaitForExit();
            }
            catch (ThreadAbortException)
            {
                Logger.Error("Ocorreu um erro não tratado, todas as conexões serão finalizadas");
                throw;
            }
            catch (Exception exp)
            {
                Logger.Error(exp, "Ocorreu um erro e com isso as conexões serão finalizadas", true);
            }
        }
        #endregion
    }
}