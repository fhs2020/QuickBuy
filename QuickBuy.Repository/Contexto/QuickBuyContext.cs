﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Contexto
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                                                    new FormaPagamento() 
                                                    {
                                                    Id = 1, Nome= "Boleto", 
                                                    Descricao = "Forma de pagamento boleto" 
                                                    },
                                                    new FormaPagamento()  
                                                    {
                                                    Id = 2, Nome = "Cartao de Credito", 
                                                    Descricao = "Forma de pagamento cartao de credito"
                                                    },
                                                    new FormaPagamento() 
                                                    {
                                                    Id = 3, Nome = "Deposito", 
                                                    Descricao = "Forma de pagamento Deposito" 
                                                    });  
                                              

            base.OnModelCreating(modelBuilder);
        }

    }
}
