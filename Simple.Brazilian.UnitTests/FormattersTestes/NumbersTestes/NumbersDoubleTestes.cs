﻿using Simple.Brazilian.Formatters;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.NumbersTestes
{
    public class NumbersDoubleTestes
    {
        //[Theory]
        //[InlineData(0, "")]
        public void Numero_ToDouble_0(double expected, string test)
        {
            throw new NotImplementedException();
        }

        [Theory]
        [InlineData("-10,75", -10.75)]
        [InlineData("0,00", 0)]
        [InlineData("1,00", 1)]
        [InlineData("2,00", 2)]
        [InlineData("10,50", 10.5)]
        [InlineData("100,99", 100.99)]
        [InlineData("250,11", 250.11)]
        public void Numero_ToText_N2(string expected, double test)
        {
            Assert.Equal(expected, Numbers.ToText(test, 2));
        }

        [Theory]
        [InlineData("-10,4", -10.45)]
        [InlineData("-10,6", -10.55)]
        [InlineData("-10,6", -10.65)]
        [InlineData("-10,8", -10.75)]
        [InlineData("-10,8", -10.85)]
        [InlineData("0,0", 0)]
        [InlineData("1,0", 1)]
        [InlineData("2,0", 2)]
        [InlineData("10,5", 10.5)]
        [InlineData("101,0", 100.99)]
        [InlineData("250,1", 250.11)]
        public void Numero_ToText_N1(string expected, double test)
        {
            Assert.Equal(expected, Numbers.ToText(test, 1));
        }

        [Theory]
        // Quando o algarismo a ser conservado for seguido de algarismo inferior a 5,
        // o algarismo a ser conservado permanece sem alteração
        [InlineData("4,30", 4.303)]
        // Quando o algarismo a ser conservado for seguido de algarismo superior a 5,
        // ou igual a 5 seguindo de um algorismo diferente de zero,
        // soma-se uma unidade ao algarismo a ser conservado
        [InlineData("15,49", 15.4875)]
        // Quando o algarismo a ser conservado for ímpar, seguido de 5 e posteriormente de zeros,
        // soma-se uma unidade ao algarismo a ser conservado
        [InlineData("25,78", 25.7750)]
        // Quando o algarismo a ser conservado for par, seguido de 5 e posteriormente de zeros,
        // o algarismo a ser conservado permanece sem alteração
        [InlineData("31,72", 31.7250)]
        public void Numero_ToText_N2_ABNT(string expected, double test)
        {
            Assert.Equal(expected, Numbers.ToText(test, 2));
        }
    }
}
