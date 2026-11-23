public enum EnchantmentType
{
  Fiery = 0,
  Crusader = 1,
  Berzerking = 2,
}

public enum WeaponType
{
  QuelSerrar = 0,
  ArcaniteReaper = 1,
  Shadowmourne = 2,
}

public static class GameSettings
{
  /// <summary>
  /// Paramètres généraux du jeu
  /// </summary>
  public static class General
  {
    public const int PlayerCount = 2;
    public const int StartingHealth = 100;
    public const int MinimumHealth = 0;
    public const int MinAttackStrength = 10;
    public const int MaxAttackStrength = 20;
    public const int MissDamage = 0;
    public const int EnchantmentTypeCountPerDuel = 3;
    public const int MaxEnchantmentsPerAttack = 3;
  }

  /// <summary>
  /// Paramètres des armes disponibles dans le jeu
  /// </summary>
  public static class Weapon
  {
    /// <summary>
    /// Paramètres de l'arme Quel'Serrar
    /// </summary>
    public static class QuelSerrar
    {
      public const double HitChance = 1.0;
    }


    /// <summary>
    /// Paramètres de l'arme Arcanite Reaper
    /// </summary>
    public static class ArcaniteReaper
    {
      public const double HitChance = 0.5;
      public const double StrengthMultiplier = 1.5;
    }

    /// <summary>
    /// Paramètres de l'arme Shadowmourne
    /// </summary>
    public static class Shadowmourne
    {
      public const double HitChance = 0.33;

      public const double StrengthMultiplier = 1.0;
    }

  }

  /// <summary>
  /// Paramètres des enchantements disponibles dans le jeu
  /// </summary>
  public static class Enchantment
  {
    /// <summary>
    /// HP de dégâts supplémentaire pour mettre le feu à l'arme
    /// </summary>
    public const int FieryDamage = 5;

    /// <summary>
    /// Multiplicateur de dégâts pour l'enchantement "Berserking"
    /// </summary>
    public const double BerserkingMultiplier = 1.25;

    /// <summary>
    /// HP de dégâts minimum pour l'enchantement "Crusader"
    /// </summary>
    public const int CrusaderMinimumDamage = 30;
  }
}
