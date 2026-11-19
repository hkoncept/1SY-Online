public static class GameSettings
{
  // Duel et tirage inclusif


/// <summary>
/// Paramètres généraux du jeu
/// </summary>
public static class General {
  public const int PlayerCount = 2;
  public const int StartingHealth = 100;
  public const int MinimumHealth = 0;
  public const int MinAttackRoll = 10;
  public const int MaxAttackRoll = 20;
  public const int MissDamage = 0;
  public const int EnchantmentChargesPerDuel = 3;
  public const int MaxEnchantmentsPerAttack = 3;
}

/// <summary>
/// Paramètres du duel lorsque deux ordinateurs combattent
/// </summary>
public static class Duel
  {
    public const int DuelTurns = 10;
    public const double DuelSeconds = 30;
    public const double TurnDelaySeconds = DuelSeconds / DuelTurns;
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
      public const int MissingHealthStep = 20;
      public const int MaxWoundBonus = 4;
    }



  /// <summary>
  /// Paramètres de l'arme Arcanite Reaper
  /// </summary>
  public static class ArcaniteReaper
  {
    public const double HitChance = 0.75;
    public const int HalfRollDivisor = 2;
    public const int GrazeMaxRoll = 12;
    public const int GrazePenalty = 2;
    public const int HeavyMinRoll = 17;
    public const int HeavyBonus = 4;
  }

  /// <summary>
  /// Paramètres de l'arme Shadowmourne
  /// </summary>
  public static class Shadowmourne
  {
    public const double HitChance = 0.50;
    public const int DamageMultiplier = 2;
    public const int MissingHealthStep = 20;
    public const int DamagePerStep = 3;
  }
  
  }

/// <summary>
/// Paramètres des enchantements disponibles dans le jeu
/// </summary>
public static class Enchantment
  {
    /// <summary>
    /// HP supplémentaire pour mettre le feu à l'arme
    /// </summary>
    public const int FieryWeaponDamageBonus = 5;

    /// <summary>
    /// Multiplicateur de dégâts pour l'enchantement "Berserking"
    /// </summary>
    public const double BerserkingMultiplier = 1.5;

    /// <summary>
    /// HP de dégâts minimum pour l'enchantement "Crusader"
    /// </summary>
    public const int CrusaderMinimumDamage = 20;
  }
}