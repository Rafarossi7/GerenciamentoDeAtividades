using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GerenciamentoAtividadesApi.Models;

namespace GerenciamentoAtividadesApi.Data.Map
{

        public class UsuarioMap : IEntityTypeConfiguration<Usuario>
        {
            public void Configure(EntityTypeBuilder<Usuario> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
                builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
                builder.Property(x => x.DataCadastro).IsRequired();
                builder.Property(x => x.Ativo).IsRequired().HasDefaultValue(true);

            }
        }
        
    
}
