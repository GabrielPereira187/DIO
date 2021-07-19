using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CursoTeste
{
    public class CategoriasControllerTeste
    {
        private readonly Mock<DbSet<Categoria>> mockSet;
        private readonly Mock<Context> mockContext;
        private readonly Categoria categoria;
        public CategoriasControllerTeste()
        {
            mockSet = new Mock<DbSet<Categoria>>();
            mockContext = new Mock<Context>();
            categoria = new Categoria { id = 1, descricao = "Categoria 1" };

            mockContext.Setup(m => m.categorias).Returns(mockSet.Object);

            mockContext.Setup(m => m.categorias.FindAsync(1)).ReturnsAsync(categoria);

            mockContext.Setup(m => m.setModified(categoria));

            mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
        }
        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(mockContext.Object);

            await service.GetCategoria(1);
            mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CategoriasController(mockContext.Object);
            await service.PutCategoria(1, categoria);
            mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
        [Fact]
        public async Task Post_Categoria()
        {
            var service = new CategoriasController(mockContext.Object);
            await service.PostCategoria(1, categoria);
            mockSet.Verify(x => x.Add(categoria), Times.Once);
            mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [Fact]
        public async Task Delete_Categoria()
        {
            var service = new CategoriasController(mockContext.Object);
            await service.PostCategoria(1, categoria);
            mockSet.Verify(m => m.FindAsync(1), Times.Once);
            mockSet.Verify(x => x.Remove(categoria), Times.Once);
            mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
