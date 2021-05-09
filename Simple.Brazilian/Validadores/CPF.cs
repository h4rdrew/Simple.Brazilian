﻿using System;

namespace Simple.Brazilian.Validadores
{
    public static class CPF
    {
        public static bool IsValid(string cpf)
        {
            throw new NotImplementedException();
        }

        public static string Mask(string cpf) => Formatadores.Texto.AplicaMascara(cpf, "___.___.___-__");
        public static string Unmask(string cpf) => Formatadores.Texto.RemoveMascara(cpf);

    }
}