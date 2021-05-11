namespace GenshinImpactTool.Model
{
    public class Character
    {

        private string _IconPath;
        private string _Name;
        private string _Vision;
        private string _Weapon;
        private int _Level;
        private string _TalentBook;
        private string _TalentMaterial;
        private string _TalentBossMaterial;
        private string _AscensionBossMaterial;
        private int _BasicAtackLevel;
        private int _ElementalSkillLevel;
        private int _ElementalBurstLevel;

        public string IconPath { get => _IconPath; set => _IconPath = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Vision { get => _Vision; set => _Vision = value; }
        public string Weapon { get => _Weapon; set => _Weapon = value; }
        public int Level { get => _Level; set => _Level = value; }
        public string TalentBook { get => _TalentBook; set => _TalentBook = value; }
        public string TalentMaterial { get => _TalentMaterial; set => _TalentMaterial = value; }
        public string TalentBossMaterial { get => _TalentBossMaterial; set => _TalentBossMaterial = value; }
        public string AscensionBossMaterial { get => _AscensionBossMaterial; set => _AscensionBossMaterial = value; }
        public int BasicAtackLevel { get => _BasicAtackLevel; set => _BasicAtackLevel = value; }
        public int ElementalSkillLevel { get => _ElementalSkillLevel; set => _ElementalSkillLevel = value; }
        public int ElementalBurstLevel { get => _ElementalBurstLevel; set => _ElementalBurstLevel = value; }
    }
}
