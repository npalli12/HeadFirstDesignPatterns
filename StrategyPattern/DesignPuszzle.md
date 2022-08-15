# Design Puzzle pg 25

```mermaid
graph TD
Character--has-a-->WeaponBehavior
Queen--is-a-->Character
King--is-a-->Character
Troll--is-a-->Character
Knight--is-a-->Character
KnifeBehavior--imlements-->WeaponBehavior
BowAndArrowBehavior--imlements-->WeaponBehavior
AxeBehavior--imlements-->WeaponBehavior
SwordBehavior--imlements-->WeaponBehavior
Character-->setWeapon
```