﻿namespace PointBlank.IBO.Database
{
    using System.ServiceModel;
    using IBO.Base;
    using OR.Database;

    [ServiceContract]
    public interface IContaBo : IBaseBo<Conta>
    {
        /// <summary>
        /// Obtém uma conta do banco de dados
        /// </summary>
        /// <param name="login">Login</param>
        /// <param name="senha">Senha</param>
        /// <param name="ip">endereço de ip</param>
        /// <param name="mac">mac da maquina</param>
        /// <param name="validar">Se True irá Validar se não encontrar uma conta</param>
        /// <param name="validarSenha">Se true irá validar a senha</param>
        /// <returns>A conta se houver</returns>
        [OperationContract]
        Conta ObterContaPorLogin(string login, string senha, string ip, string mac, bool validar, bool validarSenha);
    }
}
