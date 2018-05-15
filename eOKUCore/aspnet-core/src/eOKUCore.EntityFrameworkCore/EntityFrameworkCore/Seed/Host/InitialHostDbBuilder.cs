namespace eOKUCore.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly eOKUCoreDbContext _context;

        public InitialHostDbBuilder(eOKUCoreDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
