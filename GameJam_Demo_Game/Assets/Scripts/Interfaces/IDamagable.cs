/// <summary>
/// The interace to base any object that can take damage
/// </summary>
public interface IDamagable
{
    /// <summary>
    /// The health points of the object
    /// </summary>
    int HP { get; set; }

    /// <summary>
    /// Function to call when an I damagable is hit
    /// </summary>
    /// <param name="damage">The amount of damage hit for</param>
    void Hit(int damage);
}