using KHSave;
using System.Collections.Generic;
using KH02.SaveEditor.Models;
using KHSave.Models;
using KHSave.Types;
using Xe.Tools;

namespace KH02.SaveEditor.ViewModels
{
	public class PlayerViewModel : BaseNotifyPropertyChanged
	{
		private readonly PlayableCharacter playableCharacter;
		private readonly int index;

		public PlayerViewModel(PlayableCharacter playableCharacter, int index)
		{
			this.playableCharacter = playableCharacter;
			this.index = index;

			WeaponType = new GenericEnumModel<EnumIconTypeModel<WeaponType>, WeaponType>();

			Armors = new EquipmentItemsViewModel<ArmorType>(playableCharacter.Armors);
			Accessories = new EquipmentItemsViewModel<AccessoryType>(playableCharacter.Accessories);
			Consumables = new EquipmentItemsViewModel<ConsumableType>(playableCharacter.Items);

			AiCombatStyle = new ItemComboBoxModel<AiCombatStyleType>(
				() => playableCharacter.Ai.CombatStyle,
				x => playableCharacter.Ai.CombatStyle = x);
			AiAbility = new ItemComboBoxModel<AiAbilityType>(
				() => playableCharacter.Ai.Abilitiy,
				x => playableCharacter.Ai.Abilitiy = x);
			AiRecovery = new ItemComboBoxModel<AiRecoveryType>(
				() => playableCharacter.Ai.Recovery,
				x => playableCharacter.Ai.Recovery = x);
		}

		public string Name => ((PlayableCharacterType)index).ToString();

		public GenericEnumModel<EnumIconTypeModel<WeaponType>, WeaponType> WeaponType { get; }

		public byte AtkBoost
		{
			get => playableCharacter.AtkBoost;
			set => playableCharacter.AtkBoost = value;
		}

		public byte MagBoost
		{
			get => playableCharacter.MagBoost;
			set => playableCharacter.MagBoost = value;
		}

		public byte DefBoost
		{
			get => playableCharacter.DefBoost;
			set => playableCharacter.DefBoost = value;
		}

		public byte ApBoost
		{
			get => playableCharacter.ApBoost;
			set => playableCharacter.ApBoost = value;
		}

		public int Hp {
			get => playableCharacter.Hp;
			set => playableCharacter.Hp = value;
		}

		public int Mp
		{
			get => playableCharacter.Mp;
			set => playableCharacter.Mp = value;
		}

		public int Focus
		{
			get => playableCharacter.Focus;
			set => playableCharacter.Focus = value;
		}

		public WeaponType Weapon1
		{
			get => playableCharacter.Weapons[0].WeaponId;
			set => playableCharacter.Weapons[0].WeaponId = value;
		}

		public WeaponType Weapon2
		{
			get => playableCharacter.Weapons[1].WeaponId;
			set => playableCharacter.Weapons[1].WeaponId = value;
		}

		public WeaponType Weapon3
		{
			get => playableCharacter.Weapons[2].WeaponId;
			set => playableCharacter.Weapons[2].WeaponId = value;
		}

		public EquipmentItemsViewModel<ArmorType> Armors { get; }
		public EquipmentItemsViewModel<AccessoryType> Accessories { get; }
		public EquipmentItemsViewModel<ConsumableType> Consumables { get; }

		public ItemComboBoxModel<AiCombatStyleType> AiCombatStyle { get; }
		public ItemComboBoxModel<AiAbilityType> AiAbility { get; }
		public ItemComboBoxModel<AiRecoveryType> AiRecovery { get; }


		public IEnumerable<Ability> Abilities
		{
			get => playableCharacter.Abilities;
			set { }
		}

		public string Text => playableCharacter.ToString();
	}
}
