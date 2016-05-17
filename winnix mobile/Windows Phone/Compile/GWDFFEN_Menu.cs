/**
 * Code généré par WinDev Mobile - NE PAS MODIFIER !
 * Objet WinDev Mobile : Fenêtre
 * Classe Windows Phone : FEN_Menu
 * Date : 17/05/2016 13:52:58
 * Version de wdnet.dll  : 20.0.107.0
 */


using PCSOFT.Public.WL.VM;
using PCSOFT.Public.IHM.Menu;
using PCSOFT.Public.WL.DateHeure;
using PCSOFT.Public.COM.Sock;
using PCSOFT.Public.WL.HTTP;
using PCSOFT.Public.IHM.ChampBouton;
using PCSOFT.Public.WL.Chaine;
using PCSOFT.Public.IHM.ChampSelecteur;
using PCSOFT.Public.IHM.ChampInterrupteur;
using PCSOFT.Public.IHM.ChampSaisie;
using PCSOFT.Public.IHM.ChampZR;
using PCSOFT.Public.WL.ChampZR;
using PCSOFT.Public.IHM.IHMCore;
using PCSOFT.Public.WL.IHMCore;
using PCSOFT.Public.Core;
using PCSOFT.Public.Core.Contexte;
using PCSOFT.Public.Core.Navigation;
using PCSOFT.Public.Core.Types;

namespace GenerationPhone7
{
public class GWDFFEN_Menu : WDFenetre
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu
////////////////////////////////////////////////////////////////////////////

public GWDFFEN_Menu() : base()
{
Racine = this;
Parent = this;
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des groupes de champs de FEN_Menu
////////////////////////////////////////////////////////////////////////////

/**
 * GR_Elements
 */
public class GWDGR_Elements : WDGroupeChamp
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.GR_Elements
////////////////////////////////////////////////////////////////////////////

public GWDGR_Elements() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs de FEN_Menu.GR_Elements
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Nom = "GR_Elements";
GEN_Type = 58;

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDGR_Elements mWD_GR_Elements;

/**
 * GR_Boutons
 */
public class GWDGR_Boutons : WDGroupeChamp
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.GR_Boutons
////////////////////////////////////////////////////////////////////////////

public GWDGR_Boutons() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs de FEN_Menu.GR_Boutons
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Nom = "GR_Boutons";
GEN_Type = 58;

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDGR_Boutons mWD_GR_Boutons;

/**
 * GR_Checkbox
 */
public class GWDGR_Checkbox : WDGroupeChamp
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.GR_Checkbox
////////////////////////////////////////////////////////////////////////////

public GWDGR_Checkbox() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs de FEN_Menu.GR_Checkbox
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Nom = "GR_Checkbox";
GEN_Type = 58;

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDGR_Checkbox mWD_GR_Checkbox;

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs de FEN_Menu
////////////////////////////////////////////////////////////////////////////

/**
 * ZR_Menu
 */
public class GWDZR_Menu : WDZoneRepetee
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu
////////////////////////////////////////////////////////////////////////////

public GWDZR_Menu() : base()
{
}
public class GWDZR_Menu_ITEM : ItemZR
{
private GWDZR_Menu Parent;
public GWDZR_Menu_ITEM(GWDZR_Menu Parent) : base(Parent)
{
this.Parent = Parent;
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu
////////////////////////////////////////////////////////////////////////////

/**
 * SAI_NomSociete
 */
public class GWDSAI_NomSociete : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_NomSociete
////////////////////////////////////////////////////////////////////////////

public GWDSAI_NomSociete() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.SAI_NomSociete
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 5209218664ul;
GEN_CheckSum = "708455431";
GEN_Nom = "SAI_NomSociete";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 28);
GEN_SetTailleInitiale(316, 71);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(1)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Nom de la société")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 5;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_NomSociete mWD_SAI_NomSociete = new GWDSAI_NomSociete();

/**
 * INT_Interlocuteur
 */
public class GWDINT_Interlocuteur : WDInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Interlocuteur
////////////////////////////////////////////////////////////////////////////

public GWDINT_Interlocuteur() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.INT_Interlocuteur
////////////////////////////////////////////////////////////////////////////

/**
 * INT_Interlocuteur_Option_0
 */
public class GWDINT_Interlocuteur_Option_0 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Interlocuteur)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Interlocuteur Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDINT_Interlocuteur_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Achat")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Interlocuteur_Option_0 mWD_INT_Interlocuteur_Option_0 = new GWDINT_Interlocuteur_Option_0();

/**
 * INT_Interlocuteur_Option_1
 */
public class GWDINT_Interlocuteur_Option_1 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Interlocuteur)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Interlocuteur Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDINT_Interlocuteur_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("BE")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Interlocuteur_Option_1 mWD_INT_Interlocuteur_Option_1 = new GWDINT_Interlocuteur_Option_1();

/**
 * INT_Interlocuteur_Option_2
 */
public class GWDINT_Interlocuteur_Option_2 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Interlocuteur)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Interlocuteur Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDINT_Interlocuteur_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.INT_Interlocuteur.INT_Interlocuteur_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Entretien")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Interlocuteur_Option_2 mWD_INT_Interlocuteur_Option_2 = new GWDINT_Interlocuteur_Option_2();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_INT_Interlocuteur_Option_0);
GEN_AjouteOption(mWD_INT_Interlocuteur_Option_1);
GEN_AjouteOption(mWD_INT_Interlocuteur_Option_2);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 22227708164ul;
GEN_CheckSum = "878824331";
GEN_Nom = "INT_Interlocuteur";
GEN_Type = 5;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 101);
GEN_SetTailleInitiale(316, 124);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(2)));
GEN_SetAncrage(1000, 1000, 1000, 1000, 0);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Interlocuteur")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
GEN_LibelleOptionMultilignes = false;
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Checkbox,GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Interlocuteur mWD_INT_Interlocuteur = new GWDINT_Interlocuteur();

/**
 * INT_Produits
 */
public class GWDINT_Produits : WDInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.INT_Produits
////////////////////////////////////////////////////////////////////////////

/**
 * INT_Produits_Option_0
 */
public class GWDINT_Produits_Option_0 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Roulement")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_0 mWD_INT_Produits_Option_0 = new GWDINT_Produits_Option_0();

/**
 * INT_Produits_Option_1
 */
public class GWDINT_Produits_Option_1 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Guidage")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_1 mWD_INT_Produits_Option_1 = new GWDINT_Produits_Option_1();

/**
 * INT_Produits_Option_2
 */
public class GWDINT_Produits_Option_2 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Transmission")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_2 mWD_INT_Produits_Option_2 = new GWDINT_Produits_Option_2();

/**
 * INT_Produits_Option_3
 */
public class GWDINT_Produits_Option_3 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_3
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_3() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°4 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_3
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Etanchéité")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_3 mWD_INT_Produits_Option_3 = new GWDINT_Produits_Option_3();

/**
 * INT_Produits_Option_4
 */
public class GWDINT_Produits_Option_4 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_4
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_4() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°5 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_4
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Graisse-Colle")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_4 mWD_INT_Produits_Option_4 = new GWDINT_Produits_Option_4();

/**
 * INT_Produits_Option_5
 */
public class GWDINT_Produits_Option_5 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Produits)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Produits Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_5
////////////////////////////////////////////////////////////////////////////

public GWDINT_Produits_Option_5() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°6 de FEN_Menu.ZR_Menu.INT_Produits.INT_Produits_Option_5
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Nouveaux Produits")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits_Option_5 mWD_INT_Produits_Option_5 = new GWDINT_Produits_Option_5();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_INT_Produits_Option_0);
GEN_AjouteOption(mWD_INT_Produits_Option_1);
GEN_AjouteOption(mWD_INT_Produits_Option_2);
GEN_AjouteOption(mWD_INT_Produits_Option_3);
GEN_AjouteOption(mWD_INT_Produits_Option_4);
GEN_AjouteOption(mWD_INT_Produits_Option_5);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 10350172864ul;
GEN_CheckSum = "759867812";
GEN_Nom = "INT_Produits";
GEN_Type = 5;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(-1, 227);
GEN_SetTailleInitiale(316, 217);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(3)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Produits")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
GEN_LibelleOptionMultilignes = false;
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements,GR_Checkbox")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Produits mWD_INT_Produits = new GWDINT_Produits();

/**
 * INT_Objet_Visite
 */
public class GWDINT_Objet_Visite : WDInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°4 de FEN_Menu.ZR_Menu.INT_Objet_Visite
////////////////////////////////////////////////////////////////////////////

/**
 * INT_Objet_Visite_Option_0
 */
public class GWDINT_Objet_Visite_Option_0 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Presentation")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_0 mWD_INT_Objet_Visite_Option_0 = new GWDINT_Objet_Visite_Option_0();

/**
 * INT_Objet_Visite_Option_1
 */
public class GWDINT_Objet_Visite_Option_1 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Decouverte")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_1 mWD_INT_Objet_Visite_Option_1 = new GWDINT_Objet_Visite_Option_1();

/**
 * INT_Objet_Visite_Option_2
 */
public class GWDINT_Objet_Visite_Option_2 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Negociation")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_2 mWD_INT_Objet_Visite_Option_2 = new GWDINT_Objet_Visite_Option_2();

/**
 * INT_Objet_Visite_Option_3
 */
public class GWDINT_Objet_Visite_Option_3 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_3
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_3() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°4 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_3
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Commande")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_3 mWD_INT_Objet_Visite_Option_3 = new GWDINT_Objet_Visite_Option_3();

/**
 * INT_Objet_Visite_Option_4
 */
public class GWDINT_Objet_Visite_Option_4 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_4
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_4() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°5 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_4
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Relationnel")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_4 mWD_INT_Objet_Visite_Option_4 = new GWDINT_Objet_Visite_Option_4();

/**
 * INT_Objet_Visite_Option_5
 */
public class GWDINT_Objet_Visite_Option_5 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_5
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_5() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°6 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_5
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("SAV")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_5 mWD_INT_Objet_Visite_Option_5 = new GWDINT_Objet_Visite_Option_5();

/**
 * INT_Objet_Visite_Option_6
 */
public class GWDINT_Objet_Visite_Option_6 : WDOptionInterrupteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDINT_Objet_Visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDINT_Objet_Visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_6
////////////////////////////////////////////////////////////////////////////

public GWDINT_Objet_Visite_Option_6() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°7 de FEN_Menu.ZR_Menu.INT_Objet_Visite.INT_Objet_Visite_Option_6
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Pneumatique")));
SetPropriete(WDObjet.EPROPRIETE.PropTroisEtats, (new WDBooleen(false)));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite_Option_6 mWD_INT_Objet_Visite_Option_6 = new GWDINT_Objet_Visite_Option_6();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_0);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_1);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_2);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_3);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_4);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_5);
GEN_AjouteOption(mWD_INT_Objet_Visite_Option_6);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 10621230064ul;
GEN_CheckSum = "762578801";
GEN_Nom = "INT_Objet_Visite";
GEN_Type = 5;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 446);
GEN_SetTailleInitiale(316, 309);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(4)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Objet de la visite")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
GEN_LibelleOptionMultilignes = true;
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements,GR_Checkbox")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDINT_Objet_Visite mWD_INT_Objet_Visite = new GWDINT_Objet_Visite();

/**
 * SAI_CommentaireActivite
 */
public class GWDSAI_CommentaireActivite : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_CommentaireActivite
////////////////////////////////////////////////////////////////////////////

public GWDSAI_CommentaireActivite() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°5 de FEN_Menu.ZR_Menu.SAI_CommentaireActivite
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 11066320764ul;
GEN_CheckSum = "767028465";
GEN_Nom = "SAI_CommentaireActivite";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 757);
GEN_SetTailleInitiale(316, 71);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(5)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Commentaire activité")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 3;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_CommentaireActivite mWD_SAI_CommentaireActivite = new GWDSAI_CommentaireActivite();

/**
 * SEL_Durée
 */
public class GWDSEL_Duree : WDSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Durée
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Duree() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°6 de FEN_Menu.ZR_Menu.SEL_Durée
////////////////////////////////////////////////////////////////////////////

/**
 * SEL_Durée_Option_0
 */
public class GWDSEL_Duree_Option_0 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Duree)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Duree Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Duree_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Jour")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Duree_Option_0 mWD_SEL_Duree_Option_0 = new GWDSEL_Duree_Option_0();

/**
 * SEL_Durée_Option_1
 */
public class GWDSEL_Duree_Option_1 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Duree)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Duree Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Duree_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Matin")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Duree_Option_1 mWD_SEL_Duree_Option_1 = new GWDSEL_Duree_Option_1();

/**
 * SEL_Durée_Option_2
 */
public class GWDSEL_Duree_Option_2 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Duree)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Duree Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Duree_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.SEL_Durée.SEL_Durée_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Après-midi")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Duree_Option_2 mWD_SEL_Duree_Option_2 = new GWDSEL_Duree_Option_2();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_SEL_Duree_Option_0);
GEN_AjouteOption(mWD_SEL_Duree_Option_1);
GEN_AjouteOption(mWD_SEL_Duree_Option_2);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 11692381564ul;
GEN_CheckSum = "773290932";
GEN_Nom = "SEL_Durée";
GEN_Type = 6;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 830);
GEN_SetTailleInitiale(316, 134);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(6)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Durée")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Duree mWD_SEL_Duree = new GWDSEL_Duree();

/**
 * SAI_Commentaire
 */
public class GWDSAI_Commentaire : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_Commentaire
////////////////////////////////////////////////////////////////////////////

public GWDSAI_Commentaire() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°7 de FEN_Menu.ZR_Menu.SAI_Commentaire
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 12011011264ul;
GEN_CheckSum = "776483435";
GEN_Nom = "SAI_Commentaire";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 966);
GEN_SetTailleInitiale(316, 72);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(7)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Commentaire")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 3;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(true)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

/**
 * Traitement: A chaque modification de SAI_Commentaire ( ZR_Menu )
 */
protected override WDObjet GEN_vPCODE_Modification(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "A chaque modification de SAI_Commentaire ( ZR_Menu )";
base.GEN_vPCODE_Modification(pcode);

// si taille(SAI_Commentaire) >= 160 ALORS
if(APIChaine.GEN_Taille(this).OpSupEgal(160))
{
// 	SAI_Commentaire..Etat = grisé
this.SetPropriete(WDObjet.EPROPRIETE.PropEtat,new WDEntier(4));

}

return new WDVoid("GEN_vPCODE_Modification");
}



// Activation des écouteurs: 
protected void _ActiveEcoute()
{
GEN_ActiveEvenement_Modification();
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_Commentaire mWD_SAI_Commentaire = new GWDSAI_Commentaire();

/**
 * SAI_Collaborateur
 */
public class GWDSAI_Collaborateur : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_Collaborateur
////////////////////////////////////////////////////////////////////////////

public GWDSAI_Collaborateur() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°8 de FEN_Menu.ZR_Menu.SAI_Collaborateur
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 12239738264ul;
GEN_CheckSum = "778762906";
GEN_Nom = "SAI_Collaborateur";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 1129);
GEN_SetTailleInitiale(316, 71);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(8)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Collaborateur")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 3;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_Collaborateur mWD_SAI_Collaborateur = new GWDSAI_Collaborateur();

/**
 * SEL_TypeVisite
 */
public class GWDSEL_TypeVisite : WDSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°9 de FEN_Menu.ZR_Menu.SEL_TypeVisite
////////////////////////////////////////////////////////////////////////////

/**
 * SEL_TypeVisite_Option_0
 */
public class GWDSEL_TypeVisite_Option_0 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Solo")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_0 mWD_SEL_TypeVisite_Option_0 = new GWDSEL_TypeVisite_Option_0();

/**
 * SEL_TypeVisite_Option_1
 */
public class GWDSEL_TypeVisite_Option_1 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Fabriquant")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_1 mWD_SEL_TypeVisite_Option_1 = new GWDSEL_TypeVisite_Option_1();

/**
 * SEL_TypeVisite_Option_2
 */
public class GWDSEL_TypeVisite_Option_2 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RRDP TGM")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_2 mWD_SEL_TypeVisite_Option_2 = new GWDSEL_TypeVisite_Option_2();

/**
 * SEL_TypeVisite_Option_3
 */
public class GWDSEL_TypeVisite_Option_3 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_3
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_3() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°4 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_3
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RV")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_3 mWD_SEL_TypeVisite_Option_3 = new GWDSEL_TypeVisite_Option_3();

/**
 * SEL_TypeVisite_Option_4
 */
public class GWDSEL_TypeVisite_Option_4 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_4
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_4() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°5 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_4
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RRGC")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_4 mWD_SEL_TypeVisite_Option_4 = new GWDSEL_TypeVisite_Option_4();

/**
 * SEL_TypeVisite_Option_5
 */
public class GWDSEL_TypeVisite_Option_5 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_5
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_5() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°6 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_5
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("DR")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_5 mWD_SEL_TypeVisite_Option_5 = new GWDSEL_TypeVisite_Option_5();

/**
 * SEL_TypeVisite_Option_6
 */
public class GWDSEL_TypeVisite_Option_6 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_6
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_6() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°7 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_6
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Energy SAV")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_6 mWD_SEL_TypeVisite_Option_6 = new GWDSEL_TypeVisite_Option_6();

/**
 * SEL_TypeVisite_Option_7
 */
public class GWDSEL_TypeVisite_Option_7 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_7
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_7() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°8 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_7
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("DCCN")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_7 mWD_SEL_TypeVisite_Option_7 = new GWDSEL_TypeVisite_Option_7();

/**
 * SEL_TypeVisite_Option_8
 */
public class GWDSEL_TypeVisite_Option_8 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_8
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_8() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°9 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_8
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RO")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_8 mWD_SEL_TypeVisite_Option_8 = new GWDSEL_TypeVisite_Option_8();

/**
 * SEL_TypeVisite_Option_9
 */
public class GWDSEL_TypeVisite_Option_9 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_9
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_9() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°10 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_9
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RRDP MPT")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_9 mWD_SEL_TypeVisite_Option_9 = new GWDSEL_TypeVisite_Option_9();

/**
 * SEL_TypeVisite_Option_10
 */
public class GWDSEL_TypeVisite_Option_10 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_10
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_10() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°11 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_10
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("RRDP")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_10 mWD_SEL_TypeVisite_Option_10 = new GWDSEL_TypeVisite_Option_10();

/**
 * SEL_TypeVisite_Option_11
 */
public class GWDSEL_TypeVisite_Option_11 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_TypeVisite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_TypeVisite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_11
////////////////////////////////////////////////////////////////////////////

public GWDSEL_TypeVisite_Option_11() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°12 de FEN_Menu.ZR_Menu.SEL_TypeVisite.SEL_TypeVisite_Option_11
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Invend")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite_Option_11 mWD_SEL_TypeVisite_Option_11 = new GWDSEL_TypeVisite_Option_11();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_0);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_1);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_2);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_3);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_4);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_5);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_6);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_7);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_8);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_9);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_10);
GEN_AjouteOption(mWD_SEL_TypeVisite_Option_11);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 19075773964ul;
GEN_CheckSum = "847127518";
GEN_Nom = "SEL_TypeVisite";
GEN_Type = 6;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(0, 1202);
GEN_SetTailleInitiale(316, 316);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(9)));
GEN_SetAncrage(500, 1000, 1000, 1000, 4);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Visite")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0xF4000000, false, false, false, 0, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("MS Shell Dlg", -7, 0xF4000000, false, false, false);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

/**
 * Traitement: A chaque modification de SEL_TypeVisite ( ZR_Menu )
 */
protected override WDObjet GEN_vPCODE_Modification(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "A chaque modification de SEL_TypeVisite ( ZR_Menu )";
base.GEN_vPCODE_Modification(pcode);

// OuvreFenêtreMobile(FEN_Choix_Marque,0)
APIIHMCore.GEN_OuvreFille("FEN_Choix_Marque",new WDEntier(0));

return new WDVoid("GEN_vPCODE_Modification");
}



// Activation des écouteurs: 
protected void _ActiveEcoute()
{
GEN_ActiveEvenement_Modification();
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_TypeVisite mWD_SEL_TypeVisite = new GWDSEL_TypeVisite();

/**
 * SEL_clientProspect
 */
public class GWDSEL_clientProspect : WDSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_clientProspect
////////////////////////////////////////////////////////////////////////////

public GWDSEL_clientProspect() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°10 de FEN_Menu.ZR_Menu.SEL_clientProspect
////////////////////////////////////////////////////////////////////////////

/**
 * SEL_clientProspect_Option_0
 */
public class GWDSEL_clientProspect_Option_0 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_clientProspect)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_clientProspect Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_clientProspect.SEL_clientProspect_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDSEL_clientProspect_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.SEL_clientProspect.SEL_clientProspect_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Client")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_clientProspect_Option_0 mWD_SEL_clientProspect_Option_0 = new GWDSEL_clientProspect_Option_0();

/**
 * SEL_clientProspect_Option_1
 */
public class GWDSEL_clientProspect_Option_1 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_clientProspect)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_clientProspect Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_clientProspect.SEL_clientProspect_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDSEL_clientProspect_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.SEL_clientProspect.SEL_clientProspect_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Prospect")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_clientProspect_Option_1 mWD_SEL_clientProspect_Option_1 = new GWDSEL_clientProspect_Option_1();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_SEL_clientProspect_Option_0);
GEN_AjouteOption(mWD_SEL_clientProspect_Option_1);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 16384247964ul;
GEN_CheckSum = "820382737";
GEN_Nom = "SEL_clientProspect";
GEN_Type = 6;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 1520);
GEN_SetTailleInitiale(316, 111);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(10)));
GEN_SetAncrage(1000, 1000, 1000, 1000, 0);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Client / Prospect")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_clientProspect mWD_SEL_clientProspect = new GWDSEL_clientProspect();

/**
 * SEL_Presence
 */
public class GWDSEL_Presence : WDSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Presence
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Presence() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°11 de FEN_Menu.ZR_Menu.SEL_Presence
////////////////////////////////////////////////////////////////////////////

/**
 * SEL_Presence_Option_0
 */
public class GWDSEL_Presence_Option_0 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Presence)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Presence Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_0
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Presence_Option_0() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°1 de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_0
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Hors Société")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Presence_Option_0 mWD_SEL_Presence_Option_0 = new GWDSEL_Presence_Option_0();

/**
 * SEL_Presence_Option_1
 */
public class GWDSEL_Presence_Option_1 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Presence)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Presence Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_1
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Presence_Option_1() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_1
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Agence")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Presence_Option_1 mWD_SEL_Presence_Option_1 = new GWDSEL_Presence_Option_1();

/**
 * SEL_Presence_Option_2
 */
public class GWDSEL_Presence_Option_2 : WDOptionSelecteur
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDSEL_Presence)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDSEL_Presence Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_2
////////////////////////////////////////////////////////////////////////////

public GWDSEL_Presence_Option_2() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.ZR_Menu.SEL_Presence.SEL_Presence_Option_2
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Terrain/client")));

}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Presence_Option_2 mWD_SEL_Presence_Option_2 = new GWDSEL_Presence_Option_2();
protected  override void GEN_vInitialiserSousObjets()
{
GEN_AjouteOption(mWD_SEL_Presence_Option_0);
GEN_AjouteOption(mWD_SEL_Presence_Option_1);
GEN_AjouteOption(mWD_SEL_Presence_Option_2);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 7967140264ul;
GEN_CheckSum = "736539444";
GEN_Nom = "SEL_Presence";
GEN_Type = 6;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 1633);
GEN_SetTailleInitiale(316, 128);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(11)));
GEN_SetAncrage(1000, 1000, 1000, 1000, 0);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Presence")));
GEN_SetStyleLibelle("Segoe WP", -11, 0x0, false, false, false, 2, 0, 0);
GEN_NombreColonne = 2;
GEN_SetStyleOption("Segoe WP", -7, 0x0, false, false, false);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Elements")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSEL_Presence mWD_SEL_Presence = new GWDSEL_Presence();

/**
 * SAI_Marque
 */
public class GWDSAI_Marque : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_Marque
////////////////////////////////////////////////////////////////////////////

public GWDSAI_Marque() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°12 de FEN_Menu.ZR_Menu.SAI_Marque
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 26871426864ul;
GEN_CheckSum = "926192866";
GEN_Nom = "SAI_Marque";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 4;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 1046);
GEN_SetTailleInitiale(316, 71);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(12)));
GEN_SetAncrage(1000, 1000, 0, 1000, 1);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Marque")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 5;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_Marque mWD_SAI_Marque = new GWDSAI_Marque();

/**
 * SAI_Activite_Autre
 */
public class GWDSAI_Activite_Autre : WDSaisie
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDZR_Menu_ITEM)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDZR_Menu_ITEM Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.ZR_Menu.SAI_Activite_Autre
////////////////////////////////////////////////////////////////////////////

public GWDSAI_Activite_Autre() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°13 de FEN_Menu.ZR_Menu.SAI_Activite_Autre
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 6145768064ul;
GEN_CheckSum = "719286276";
GEN_Nom = "SAI_Activite_Autre";
GEN_Type = 20001;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = true;
GEN_SetPositionInitiale(2, 1763);
GEN_SetTailleInitiale(316, 71);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(13)));
GEN_SetAncrage(1000, 1000, 0, 1000, 1);
GEN_TypeSaisie = 0;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Autre Activité")));
GEN_SetStyleLibelle("MS Shell Dlg", -11, 0x0, false, false, false, 2, 0, 0);
GEN_SetStyleSaisie("MS Shell Dlg", -11, 0x0, false, false);
GEN_PositionZoneSaisie = 5;
GEN_LargeurZoneSaisie = 316;
SetPropriete(WDObjet.EPROPRIETE.PropCadrageHorizontal, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMasqueSaisie, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropMultiligne, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-192937984)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDSAI_Activite_Autre mWD_SAI_Activite_Autre = new GWDSAI_Activite_Autre();
protected  override void GEN_vInitialiserSousObjets()
{
mWD_SAI_NomSociete.Racine = Parent.Racine;
mWD_SAI_NomSociete.Parent = this;
mWD_SAI_NomSociete.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_NomSociete);
mWD_INT_Interlocuteur.Racine = Parent.Racine;
mWD_INT_Interlocuteur.Parent = this;
mWD_INT_Interlocuteur.GEN_Parent = this;
GEN_AjouteChamp(mWD_INT_Interlocuteur);
mWD_INT_Produits.Racine = Parent.Racine;
mWD_INT_Produits.Parent = this;
mWD_INT_Produits.GEN_Parent = this;
GEN_AjouteChamp(mWD_INT_Produits);
mWD_INT_Objet_Visite.Racine = Parent.Racine;
mWD_INT_Objet_Visite.Parent = this;
mWD_INT_Objet_Visite.GEN_Parent = this;
GEN_AjouteChamp(mWD_INT_Objet_Visite);
mWD_SAI_CommentaireActivite.Racine = Parent.Racine;
mWD_SAI_CommentaireActivite.Parent = this;
mWD_SAI_CommentaireActivite.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_CommentaireActivite);
mWD_SEL_Duree.Racine = Parent.Racine;
mWD_SEL_Duree.Parent = this;
mWD_SEL_Duree.GEN_Parent = this;
GEN_AjouteChamp(mWD_SEL_Duree);
mWD_SAI_Commentaire.Racine = Parent.Racine;
mWD_SAI_Commentaire.Parent = this;
mWD_SAI_Commentaire.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_Commentaire);
mWD_SAI_Collaborateur.Racine = Parent.Racine;
mWD_SAI_Collaborateur.Parent = this;
mWD_SAI_Collaborateur.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_Collaborateur);
mWD_SEL_TypeVisite.Racine = Parent.Racine;
mWD_SEL_TypeVisite.Parent = this;
mWD_SEL_TypeVisite.GEN_Parent = this;
GEN_AjouteChamp(mWD_SEL_TypeVisite);
mWD_SEL_clientProspect.Racine = Parent.Racine;
mWD_SEL_clientProspect.Parent = this;
mWD_SEL_clientProspect.GEN_Parent = this;
GEN_AjouteChamp(mWD_SEL_clientProspect);
mWD_SEL_Presence.Racine = Parent.Racine;
mWD_SEL_Presence.Parent = this;
mWD_SEL_Presence.GEN_Parent = this;
GEN_AjouteChamp(mWD_SEL_Presence);
mWD_SAI_Marque.Racine = Parent.Racine;
mWD_SAI_Marque.Parent = this;
mWD_SAI_Marque.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_Marque);
mWD_SAI_Activite_Autre.Racine = Parent.Racine;
mWD_SAI_Activite_Autre.Parent = this;
mWD_SAI_Activite_Autre.GEN_Parent = this;
GEN_AjouteChamp(mWD_SAI_Activite_Autre);
}
}
protected override ItemZR GEN_vCreeItemZR()
{
return new GWDZR_Menu_ITEM(this);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 10798463964ul;
GEN_CheckSum = "765470989";
GEN_Nom = "ZR_Menu";
GEN_Type = 30;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = false;
GEN_SetPositionInitiale(2, 2);
GEN_SetTailleInitiale(316, 460);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(1)));
GEN_SetAncrage(1000, 1000, 1000, 1000, 10);
GEN_HauteurLigne = 1836;
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Zone répétée")));
GEN_SetStyleLibelle("Segoe WP", -11, 0xFFFFFF, false, false, false, -1, 0, 0);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(-16777216)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("")));
_ActiveEcoute();

}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDZR_Menu mWD_ZR_Menu;

/**
 * BTN_Annuler
 */
public class GWDBTN_Annuler : WDBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.BTN_Annuler
////////////////////////////////////////////////////////////////////////////

public GWDBTN_Annuler() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°2 de FEN_Menu.BTN_Annuler
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 14343963864ul;
GEN_CheckSum = "799806341";
GEN_Nom = "BTN_Annuler";
GEN_Type = 4;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = false;
GEN_SetPositionInitiale(156, 395);
GEN_SetTailleInitiale(160, 64);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(2)));
GEN_SetAncrage(500, 1000, 1000, 1000, 1);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Annuler")));
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropImageEtat, (new WDEntier(1)));
SetPropriete(WDObjet.EPROPRIETE.PropImageFond, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\WinPhone 7_BTN_Cancel.png")));
SetPropriete(WDObjet.EPROPRIETE.PropImageFondEtat, (new WDEntier(5)));
GEN_NbEtapesAnimation = 1;
GEN_PositionLibelle = 6;
SetPropriete(WDObjet.EPROPRIETE.PropCouleur, (new WDEntier(16777215)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceNom, (new WDChaine("Segoe WP")));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceTaille, (new WDEntier(-11)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceGras, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceItalique, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceSouligne, (new WDBooleen(false)));
GEN_StyleSurvol_PositionLibelle = 6;
GEN_StyleSurvol_Couleur = 0xFFFFFF;
GEN_StyleSurvol_CouleurFond = 0xE8C6B0;
GEN_StyleSurvol_NomPolice = "Segoe WP";
GEN_StyleSurvol_Taille = -11;
GEN_StyleSurvol_Gras = false;
GEN_StyleSurvol_Souligne = false;
GEN_StyleSurvol_Italique = false;
GEN_StyleEnfonce_PositionLibelle = 6;
GEN_StyleEnfonce_Couleur = 0x0;
GEN_StyleEnfonce_CouleurFond = 0xE2A11B;
GEN_StyleEnfonce_NomPolice = "Segoe WP";
GEN_StyleEnfonce_Taille = -11;
GEN_StyleEnfonce_Gras = false;
GEN_StyleEnfonce_Souligne = false;
GEN_StyleEnfonce_Italique = false;
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Boutons")));
_ActiveEcoute();

}

/**
 * Traitement: Clic sur BTN_Annuler
 */
protected override WDObjet GEN_vPCODE_Clic(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Clic sur BTN_Annuler";
base.GEN_vPCODE_Clic(pcode);

// ZR_Menu..Visible = faux
Parent.mWD_ZR_Menu.SetPropriete(WDObjet.EPROPRIETE.PropVisible,new WDBooleen(false));

// GR_Boutons..Visible = faux
Parent.mWD_GR_Boutons.SetPropriete(WDObjet.EPROPRIETE.PropVisible,new WDBooleen(false));

return new WDVoid("GEN_vPCODE_Clic");
}



// Activation des écouteurs: 
protected void _ActiveEcoute()
{
GEN_ActiveEvenement_Clic();
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDBTN_Annuler mWD_BTN_Annuler;

/**
 * BTN_Valider
 */
public class GWDBTN_Valider : WDBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de FEN_Menu.BTN_Valider
////////////////////////////////////////////////////////////////////////////

public GWDBTN_Valider() : base()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des champs du fils n°3 de FEN_Menu.BTN_Valider
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 13753078964ul;
GEN_CheckSum = "793897482";
GEN_Nom = "BTN_Valider";
GEN_Type = 4;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_EtatInitial = 0;
GEN_VisibleInitial = false;
GEN_SetPositionInitiale(5, 395);
GEN_SetTailleInitiale(160, 64);
SetPropriete(WDObjet.EPROPRIETE.PropAltitude, (new WDEntier(3)));
GEN_SetAncrage(500, 1000, 1000, 1000, 1);
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Valider")));
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropImageEtat, (new WDEntier(1)));
SetPropriete(WDObjet.EPROPRIETE.PropImageFond, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\WinPhone 7_Btn_Ok.png")));
SetPropriete(WDObjet.EPROPRIETE.PropImageFondEtat, (new WDEntier(5)));
GEN_NbEtapesAnimation = 1;
GEN_PositionLibelle = 6;
SetPropriete(WDObjet.EPROPRIETE.PropCouleur, (new WDEntier(16777215)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceNom, (new WDChaine("Segoe WP")));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceTaille, (new WDEntier(-11)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceGras, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceItalique, (new WDBooleen(false)));
SetPropriete(WDObjet.EPROPRIETE.PropPoliceSouligne, (new WDBooleen(false)));
GEN_StyleSurvol_PositionLibelle = 6;
GEN_StyleSurvol_Couleur = 0xFFFFFF;
GEN_StyleSurvol_CouleurFond = 0xE8C6B0;
GEN_StyleSurvol_NomPolice = "Segoe WP";
GEN_StyleSurvol_Taille = -11;
GEN_StyleSurvol_Gras = false;
GEN_StyleSurvol_Souligne = false;
GEN_StyleSurvol_Italique = false;
GEN_StyleEnfonce_PositionLibelle = 6;
GEN_StyleEnfonce_Couleur = 0x0;
GEN_StyleEnfonce_CouleurFond = 0xE2A11B;
GEN_StyleEnfonce_NomPolice = "Segoe WP";
GEN_StyleEnfonce_Taille = -11;
GEN_StyleEnfonce_Gras = false;
GEN_StyleEnfonce_Souligne = false;
GEN_StyleEnfonce_Italique = false;
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropPlan, (new WDEntier(0)));
SetPropriete(WDObjet.EPROPRIETE.PropGroupe, (new WDChaine("GR_Boutons")));
_ActiveEcoute();

}

/**
 * Traitement: Clic sur BTN_Valider
 */
protected override WDObjet GEN_vPCODE_Clic(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Clic sur BTN_Valider";
base.GEN_vPCODE_Clic(pcode);


////////////////////////////////////////////////////////////////////////////
// Déclaration des variables locales au traitement
// (En WLangage les variables sont encore visibles après la fin du bloc dans lequel elles sont déclarées)
////////////////////////////////////////////////////////////////////////////
WDObjet vWD_bInfosOK= new WDBooleen();

WDObjet vWD_nIndexParcoursInterrupeteur= new WDEntier();

WDObjet vWD_nBrOptionCoche= new WDEntier();



// si InternetConnecté() = faux ALORS
if(APIHTTP.GEN_InternetConnecte().OpEgal(false))
{
// 	info("pas de connexion internet")
APIIHMCore.GEN_Info("pas de connexion internet");

// 	ferme()
APIIHMCore.GEN_Ferme();

}

// bInfosOK est un booléen = vrai // reste vrai si les informations saisis sont correctes

vWD_bInfosOK.SetValeur(true);


// nIndexParcoursInterrupeteur est un entier = 1 //les interrupteurs se parcours par indice

vWD_nIndexParcoursInterrupeteur.SetValeur(1);


// nBrOptionCoche est un entier = 0 //stocke le nombre d'options cochés dans un interrupteur

vWD_nBrOptionCoche.SetValeur(0);


// si ZR_Menu[1].SAI_NomSociete = "" ALORS
if(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_NomSociete").OpEgal(""))
{
// 	info("saisissez un nom de Société")
APIIHMCore.GEN_Info("saisissez un nom de Société");

}

// TANTQUE nIndexParcoursInterrupeteur <= ZR_Menu[1].INT_Produits..Occurrence
while(vWD_nIndexParcoursInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Produits").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 	SI ZR_Menu[1].INT_Produits[nIndexParcoursInterrupeteur] = 1 ALORS
if(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Produits").GetSousElement(vWD_nIndexParcoursInterrupeteur).OpEgal(1))
{
// 		nBrOptionCoche += 1
vWD_nBrOptionCoche.SetValeur(vWD_nBrOptionCoche.OpPlus(1))
;

}

// 	nIndexParcoursInterrupeteur++
vWD_nIndexParcoursInterrupeteur.vOpInc()
;

}

// SI nBrOptionCoche > 2 ALORS
if(vWD_nBrOptionCoche.OpSup(2))
{
// 	Info("trop de produits cochés, il en faut entre 1 et 2")
APIIHMCore.GEN_Info("trop de produits cochés, il en faut entre 1 et 2");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// SI nBrOptionCoche < 1 ALORS
if(vWD_nBrOptionCoche.OpInf(1))
{
// 	Info("Pas assez de produits cochés, il en faut entre 1 et 2")
APIIHMCore.GEN_Info("Pas assez de produits cochés, il en faut entre 1 et 2");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// nIndexParcoursInterrupeteur = 1
vWD_nIndexParcoursInterrupeteur.SetValeur(1);

// nBrOptionCoche = 0
vWD_nBrOptionCoche.SetValeur(0);

// TANTQUE nIndexParcoursInterrupeteur <= ZR_Menu[1].INT_Objet_Visite..Occurrence
while(vWD_nIndexParcoursInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Objet_Visite").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 	SI ZR_Menu[1].INT_Objet_Visite[nIndexParcoursInterrupeteur] = 1 ALORS
if(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Objet_Visite").GetSousElement(vWD_nIndexParcoursInterrupeteur).OpEgal(1))
{
// 		nBrOptionCoche+= 1
vWD_nBrOptionCoche.SetValeur(vWD_nBrOptionCoche.OpPlus(1))
;

}

// 	nIndexParcoursInterrupeteur++
vWD_nIndexParcoursInterrupeteur.vOpInc()
;

}

// SI nBrOptionCoche > 2 ALORS
if(vWD_nBrOptionCoche.OpSup(2))
{
// 	Info("trop d'objets visite cochés, il en faut entre 1 et 2")
APIIHMCore.GEN_Info("trop d'objets visite cochés, il en faut entre 1 et 2");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// SI nBrOptionCoche < 1 ALORS
if(vWD_nBrOptionCoche.OpInf(1))
{
// 	Info("Pas assez d'objets visite cochés, il en faut entre 1 et 2")
APIIHMCore.GEN_Info("Pas assez d'objets visite cochés, il en faut entre 1 et 2");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// nIndexParcoursInterrupeteur = 1
vWD_nIndexParcoursInterrupeteur.SetValeur(1);

// nBrOptionCoche = 0
vWD_nBrOptionCoche.SetValeur(0);

// TANTQUE nIndexParcoursInterrupeteur <= ZR_Menu[1].INT_Interlocuteur..Occurrence
while(vWD_nIndexParcoursInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Interlocuteur").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 	SI ZR_Menu[1].INT_Interlocuteur[nIndexParcoursInterrupeteur] = 1 ALORS
if(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Interlocuteur").GetSousElement(vWD_nIndexParcoursInterrupeteur).OpEgal(1))
{
// 		nBrOptionCoche+= 1
vWD_nBrOptionCoche.SetValeur(vWD_nBrOptionCoche.OpPlus(1))
;

}

// 	nIndexParcoursInterrupeteur++
vWD_nIndexParcoursInterrupeteur.vOpInc()
;

}

// SI nBrOptionCoche > 1 ALORS
if(vWD_nBrOptionCoche.OpSup(1))
{
// 	Info("trop d'interlocuteurs cochés, il faut n'en cocher qu'un")
APIIHMCore.GEN_Info("trop d'interlocuteurs cochés, il faut n'en cocher qu'un");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// SI nBrOptionCoche < 1 ALORS
if(vWD_nBrOptionCoche.OpInf(1))
{
// 	Info("Pas assez d'objets visite cochés, il faut en cocher un")
APIIHMCore.GEN_Info("Pas assez d'objets visite cochés, il faut en cocher un");

// 	bInfosOK = Faux
vWD_bInfosOK.SetValeur(false);

}

// si ZR_Menu[1].SAI_NomSociete <> "" _ET_ bInfosOK ALORS
if((Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_NomSociete").OpDiff("") && vWD_bInfosOK.GetBool()))
{
// 	SI SocketExiste("Serveur") = Faux ALORS
if(APISocket.GEN_SocketExiste("Serveur").OpEgal(false))
{
// 		SI SocketConnecte("Serveur",8000,gsIpSocket,2000) = Faux ALORS
if(APISocket.GEN_SocketConnecte("Serveur",8000,GWDPwinnix_mobile.vWD_gsIpSocket.GetString(),2000).OpEgal(false))
{
// 			Info("le serveur est HS")
APIIHMCore.GEN_Info("le serveur est HS");

}
else
{
// 			SocketChangeModeTransmission("Serveur",SocketMarqueurFinBuffer)
APISocket.GEN_SocketChangeModeTransmission("Serveur",2);

// 			SocketEcrit("Serveur","nomClient") //message adressé au serveur
APISocket.GEN_SocketEcrit("Serveur",new WDChaine("nomClient"));

// 			SocketEcrit("Serveur",ZR_Menu[1].SAI_NomSociete) // vraies données envoyées
APISocket.GEN_SocketEcrit("Serveur",Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_NomSociete"));

// 			sNomAAjouter est une chaîne UNICODE = SocketLit("Serveur",Faux,3000) //liste de tous les noms compris dans la recherche (requête LIKE)
WDObjet vWD_sNomAAjouter= new WDChaine();


vWD_sNomAAjouter.SetValeur(APISocket.GEN_SocketLit("Serveur",false,3000));


// 			lesNoms est une chaine UNICODE = ""
WDObjet vWD_lesNoms= new WDChaine();


vWD_lesNoms.SetValeur("");


// 			bPlusieursNoms est un booléen = faux //teste si la recherche renvoie à plusieurs noms dans la base de donnée
WDObjet vWD_bPlusieursNoms= new WDBooleen();


vWD_bPlusieursNoms.SetValeur(false);


// 			SI sNomAAjouter = "" ALORS
if(vWD_sNomAAjouter.OpEgal(""))
{
// 				Info("aucun client trouvé, nous allons le créer ensemble")
APIIHMCore.GEN_Info("aucun client trouvé, nous allons le créer ensemble");

// 				SocketFerme("Serveur")
APISocket.GEN_SocketFerme("Serveur");

// 				QUAND EXCEPTION DANS
try
{
// 					OuvreFenêtreMobile(FEN_ajoutProspect, ZR_Menu[1].SAI_NomSociete)
APIIHMCore.GEN_OuvreFille("FEN_ajoutProspect",Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_NomSociete"));

}
catch(WDException exception)
{
// 					Info("crash")
APIIHMCore.GEN_Info("crash");

}

finally
{
WDException.GEN_Reset();
}

}
else
{
// 				nIndexCaractere est un entier = 1
WDObjet vWD_nIndexCaractere= new WDEntier();


vWD_nIndexCaractere.SetValeur(1);


// 				TANTQUE nIndexCaractere <= Taille(sNomAAjouter) //si l'on trouve un #, c'est qu'il y a un nom en plus, à la fin les noms
while(vWD_nIndexCaractere.OpInfEgal(APIChaine.GEN_Taille(vWD_sNomAAjouter)))
{
// 					SI sNomAAjouter[[nIndexCaractere]] <> "#" ALORS //# est le séparateur par défaut choisi pour séparer les données
if(vWD_sNomAAjouter.ExtraitChaine(vWD_nIndexCaractere.GetInt()).OpDiff("#"))
{
// 						lesNoms += sNomAAjouter[[nIndexCaractere]]
vWD_lesNoms.SetValeur(vWD_lesNoms.OpPlus(vWD_sNomAAjouter.ExtraitChaine(vWD_nIndexCaractere.GetInt())))
;

}

// 					SI sNomAAjouter[[nIndexCaractere]] = "#" _ET_ nIndexCaractere <> Taille(sNomAAjouter) ALORS
if((vWD_sNomAAjouter.ExtraitChaine(vWD_nIndexCaractere.GetInt()).OpEgal("#") && vWD_nIndexCaractere.OpDiff(APIChaine.GEN_Taille(vWD_sNomAAjouter))))
{
// 						lesNoms += ", "
vWD_lesNoms.SetValeur(vWD_lesNoms.OpPlus(", "))
;

// 						bPlusieursNoms = Vrai
vWD_bPlusieursNoms.SetValeur(true);

}

// 					nIndexCaractere++
vWD_nIndexCaractere.vOpInc()
;

}

// 				SI bPlusieursNoms ALORS
if(vWD_bPlusieursNoms.GetBool())
{
// 					Info("les noms suivants contiennent la recherche: " + lesNoms + " ,choisissez en un et recommencez la validation")
APIIHMCore.GEN_Info(new WDChaine("les noms suivants contiennent la recherche: ").OpPlus(vWD_lesNoms).OpPlus(" ,choisissez en un et recommencez la validation"));

}
else
{
// 					sValeurClientProspect est une chaine UNICODE
WDObjet vWD_sValeurClientProspect= new WDChaine();



// 					SI ZR_Menu[1].SEL_clientProspect = 1 ALORS
if(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SEL_clientProspect").OpEgal(1))
{
// 						sValeurClientProspect = "C"
vWD_sValeurClientProspect.SetValeur("C");

}
else
{
// 						sValeurClientProspect = "P"
vWD_sValeurClientProspect.SetValeur("P");

}

// 					SI bInfosOK ALORS
if(vWD_bInfosOK.GetBool())
{
// 						nIffJours est un entier = DateDifférence("19691231",DateSys()) //nombre de jours entre le 31/12/1969 et aujourd'hui
WDObjet vWD_nIffJours= new WDEntier();


vWD_nIffJours.SetValeur(APIDateHeure.GEN_DateDifference(new WDChaine("19691231"),APIDateHeure.GEN_DateDuJour()));


// 						sDonnées est une chaine UNICODE = gsCodeRepresentant+ "*" + nIffJours +"#"+ gsCodeRepresentant + "#" + ZR_Menu[1].SAI_NomSociete + "#" + ZR_Menu[1].SEL_TypeVisite + "#"  + nIffJours + "#" + nIffJours + "#" + sValeurClientProspect
WDObjet vWD_sDonnees= new WDChaine();


vWD_sDonnees.SetValeur(GWDPwinnix_mobile.vWD_gsCodeRepresentant.OpPlus("*").OpPlus(vWD_nIffJours).OpPlus("#").OpPlus(GWDPwinnix_mobile.vWD_gsCodeRepresentant).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_NomSociete")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SEL_TypeVisite")).OpPlus("#").OpPlus(vWD_nIffJours).OpPlus("#").OpPlus(vWD_nIffJours).OpPlus("#").OpPlus(vWD_sValeurClientProspect));


// 						nIndexInterrupeteur est un entier = 1
WDObjet vWD_nIndexInterrupeteur= new WDEntier();


vWD_nIndexInterrupeteur.SetValeur(1);


// 						TANTQUE nIndexInterrupeteur <= ZR_Menu[1].INT_Interlocuteur..Occurrence
while(vWD_nIndexInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Interlocuteur").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 							sDonnées += "#" + ZR_Menu[1].INT_Interlocuteur[nIndexInterrupeteur]
vWD_sDonnees.SetValeur(vWD_sDonnees.OpPlus(new WDChaine("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Interlocuteur").GetSousElement(vWD_nIndexInterrupeteur))))
;

// 							nIndexInterrupeteur++
vWD_nIndexInterrupeteur.vOpInc()
;

}

// 						nIndexInterrupeteur = 1
vWD_nIndexInterrupeteur.SetValeur(1);

// 						TANTQUE nIndexInterrupeteur <= ZR_Menu[1].INT_Produits..Occurrence
while(vWD_nIndexInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Produits").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 							sDonnées += "#" + ZR_Menu[1].INT_Produits[nIndexInterrupeteur]
vWD_sDonnees.SetValeur(vWD_sDonnees.OpPlus(new WDChaine("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Produits").GetSousElement(vWD_nIndexInterrupeteur))))
;

// 							nIndexInterrupeteur++
vWD_nIndexInterrupeteur.vOpInc()
;

}

// 						nIndexInterrupeteur = 1
vWD_nIndexInterrupeteur.SetValeur(1);

// 						TANTQUE nIndexInterrupeteur <= ZR_Menu[1].INT_Objet_Visite..Occurrence
while(vWD_nIndexInterrupeteur.OpInfEgal(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Objet_Visite").GetPropriete(WDObjet.EPROPRIETE.PropOccurrence)))
{
// 							sDonnées += "#" + ZR_Menu[1].INT_Objet_Visite[nIndexInterrupeteur]
vWD_sDonnees.SetValeur(vWD_sDonnees.OpPlus(new WDChaine("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("INT_Objet_Visite").GetSousElement(vWD_nIndexInterrupeteur))))
;

// 							nIndexInterrupeteur++
vWD_nIndexInterrupeteur.vOpInc()
;

}

// 						sDonnées += "#" + ZR_Menu[1].SAI_CommentaireActivite + "#" + ZR_Menu[1].SEL_Durée + "#" + ZR_Menu[1].SAI_Commentaire + "#" + ZR_Menu[1].SAI_Collaborateur + "#" + ZR_Menu[1].SEL_Presence + "#"+ ZR_Menu[1].SAI_Marque + "#" + ZR_Menu[1].SAI_Activite_Autre
vWD_sDonnees.SetValeur(vWD_sDonnees.OpPlus(new WDChaine("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_CommentaireActivite")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SEL_Durée")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_Commentaire")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_Collaborateur")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SEL_Presence")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_Marque")).OpPlus("#").OpPlus(Parent.mWD_ZR_Menu.GetSousElement(1).GetSousElement("SAI_Activite_Autre"))))
;

// 						QUAND EXCEPTION DANS
try
{
// 							OuvreFenêtreMobile(FEN_validation,ExtraitChaîne(sNomAAjouter,1,"#"), sDonnées)
APIIHMCore.GEN_OuvreFille("FEN_validation",APIChaine.GEN_ExtraitChaine(vWD_sNomAAjouter,1,new WDChaine("#")),vWD_sDonnees);

}
catch(WDException exception)
{
// 							Info("crash")
APIIHMCore.GEN_Info("crash");

}

finally
{
WDException.GEN_Reset();
}

}

}

}

// 			SocketFerme("Serveur")
APISocket.GEN_SocketFerme("Serveur");

}

}

}

return new WDVoid("GEN_vPCODE_Clic");
}



// Activation des écouteurs: 
protected void _ActiveEcoute()
{
GEN_ActiveEvenement_Clic();
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
}
public GWDBTN_Valider mWD_BTN_Valider;

public class GWDMAjouter_une_visite : WDMenuPrincipal
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDFFEN_Menu)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDFFEN_Menu Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de Ajouter_une_visite
////////////////////////////////////////////////////////////////////////////

public GWDMAjouter_une_visite() : base()
{
}

public class GWDMOPT_ajout_visite : WDOptionMenuBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDMAjouter_une_visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDMAjouter_une_visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de OPT_ajout_visite
////////////////////////////////////////////////////////////////////////////

public GWDMOPT_ajout_visite() : base()
{
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 10809354164ul;
GEN_Nom = "OPT_ajout_visite";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\ajouter.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Ajouter une visite")));
GEN_EtatInitial = 0;
GEN_QUID = 10809354164ul;
GEN_Nom = "OPT_ajout_visite";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\ajouter.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Ajouter une visite")));
GEN_EtatInitial = 0;
}

/**
 * Traitement: Sélection du menu de Ajouter_une_visite.OPT_ajout_visite
 */
protected override WDObjet GEN_vPCODE_SelectionMenu(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Sélection du menu de Ajouter_une_visite.OPT_ajout_visite";
base.GEN_vPCODE_SelectionMenu(pcode);

// ZR_Menu..Visible = vrai
Racine.mWD_ZR_Menu.SetPropriete(WDObjet.EPROPRIETE.PropVisible,new WDBooleen(true));

// GR_Boutons..Visible = vrai
Racine.mWD_GR_Boutons.SetPropriete(WDObjet.EPROPRIETE.PropVisible,new WDBooleen(true));

return new WDVoid("GEN_vPCODE_SelectionMenu");
}


}
public GWDMOPT_ajout_visite mWD_OPT_ajout_visite = new GWDMOPT_ajout_visite();


public class GWDMOPT_Afficher_une_visite : WDOptionMenuBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDMAjouter_une_visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDMAjouter_une_visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de OPT_Afficher_une_visite
////////////////////////////////////////////////////////////////////////////

public GWDMOPT_Afficher_une_visite() : base()
{
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 15489650564ul;
GEN_Nom = "OPT_Afficher_une_visite";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\modifier.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("afficher et modifier")));
GEN_EtatInitial = 0;
GEN_QUID = 15489650564ul;
GEN_Nom = "OPT_Afficher_une_visite";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\modifier.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("afficher et modifier")));
GEN_EtatInitial = 0;
}

/**
 * Traitement: Sélection du menu de Ajouter_une_visite.OPT_Afficher_une_visite
 */
protected override WDObjet GEN_vPCODE_SelectionMenu(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Sélection du menu de Ajouter_une_visite.OPT_Afficher_une_visite";
base.GEN_vPCODE_SelectionMenu(pcode);

// quand exception dans
try
{
// 	OuvreFenêtreMobile(FEN_Nom_Recherche)
APIIHMCore.GEN_OuvreFille("FEN_Nom_Recherche");

}
catch(WDException exception)
{
// 	Info("crash")
APIIHMCore.GEN_Info("crash");

}

finally
{
WDException.GEN_Reset();
}

return new WDVoid("GEN_vPCODE_SelectionMenu");
}


}
public GWDMOPT_Afficher_une_visite mWD_OPT_Afficher_une_visite = new GWDMOPT_Afficher_une_visite();


public class GWDMOPT_Deconnexion : WDOptionMenuBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDMAjouter_une_visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDMAjouter_une_visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de OPT_Deconnexion
////////////////////////////////////////////////////////////////////////////

public GWDMOPT_Deconnexion() : base()
{
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 18151794564ul;
GEN_Nom = "OPT_Déconnexion";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\déconnexion.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Déconnexion")));
GEN_EtatInitial = 0;
GEN_QUID = 18151794564ul;
GEN_Nom = "OPT_Déconnexion";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\déconnexion.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Déconnexion")));
GEN_EtatInitial = 0;
}

/**
 * Traitement: Sélection du menu de Ajouter_une_visite.OPT_Déconnexion
 */
protected override WDObjet GEN_vPCODE_SelectionMenu(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Sélection du menu de Ajouter_une_visite.OPT_Déconnexion";
base.GEN_vPCODE_SelectionMenu(pcode);

// ferme()
APIIHMCore.GEN_Ferme();

return new WDVoid("GEN_vPCODE_SelectionMenu");
}


}
public GWDMOPT_Deconnexion mWD_OPT_Deconnexion = new GWDMOPT_Deconnexion();


public class GWDMOPT_Quitter : WDOptionMenuBouton
{

////////////////////////////////////////////////////////////////////////////
// Accès aux parents (FEN_Menu et GWDMAjouter_une_visite)
////////////////////////////////////////////////////////////////////////////
public GWDFFEN_Menu Racine;
public GWDMAjouter_une_visite Parent;

////////////////////////////////////////////////////////////////////////////
// Déclaration des constructeurs de OPT_Quitter
////////////////////////////////////////////////////////////////////////////

public GWDMOPT_Quitter() : base()
{
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 18319001264ul;
GEN_Nom = "OPT_Quitter";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\quitter.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Quitter")));
GEN_EtatInitial = 0;
GEN_QUID = 18319001264ul;
GEN_Nom = "OPT_Quitter";
GEN_Type = 40001;
SetPropriete(WDObjet.EPROPRIETE.PropImage, (new WDChaine("C:\\Users\\alexi\\Desktop\\saves\\Saves\\winnix mobile\\quitter.png")));
SetPropriete(WDObjet.EPROPRIETE.PropLibelle, (new WDChaine("Quitter")));
GEN_EtatInitial = 0;
}

/**
 * Traitement: Sélection du menu de Ajouter_une_visite.OPT_Quitter
 */
protected override WDObjet GEN_vPCODE_SelectionMenu(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Sélection du menu de Ajouter_une_visite.OPT_Quitter";
base.GEN_vPCODE_SelectionMenu(pcode);

// FinProgramme()
APIVM.GEN_FinProgramme();

return new WDVoid("GEN_vPCODE_SelectionMenu");
}


}
public GWDMOPT_Quitter mWD_OPT_Quitter = new GWDMOPT_Quitter();

protected  override void GEN_vInitialiserSousObjets()
{
mWD_OPT_ajout_visite.Racine = Parent.Racine;
mWD_OPT_ajout_visite.Parent = this;
mWD_OPT_ajout_visite.GEN_Parent = this;
GEN_AjouteOption(mWD_OPT_ajout_visite);
mWD_OPT_Afficher_une_visite.Racine = Parent.Racine;
mWD_OPT_Afficher_une_visite.Parent = this;
mWD_OPT_Afficher_une_visite.GEN_Parent = this;
GEN_AjouteOption(mWD_OPT_Afficher_une_visite);
mWD_OPT_Deconnexion.Racine = Parent.Racine;
mWD_OPT_Deconnexion.Parent = this;
mWD_OPT_Deconnexion.GEN_Parent = this;
GEN_AjouteOption(mWD_OPT_Deconnexion);
mWD_OPT_Quitter.Racine = Parent.Racine;
mWD_OPT_Quitter.Parent = this;
mWD_OPT_Quitter.GEN_Parent = this;
GEN_AjouteOption(mWD_OPT_Quitter);
}
protected  override void GEN_vInitialiserObjet()
{
GEN_Fenetre = Racine;
GEN_QUID = 9616558464ul;
GEN_Nom = "Ajouter_une_visite";
GEN_Type = 40001;
GEN_VisibleInitial = true;
GEN_QUID = 9616558464ul;
GEN_Nom = "Ajouter_une_visite";
GEN_Type = 40001;
GEN_VisibleInitial = true;
}
}
public GWDMAjouter_une_visite mWD_Ajouter_une_visite;



/**
 * Traitement: Déclarations globales de FEN_Menu
 */
protected override WDObjet GEN_vPCODE_DeclarationGlobales(PCodeEnCours pcode,WDObjet[] WD_tabParam)
{
pcode.GEN_Libelle = "Déclarations globales de FEN_Menu";
base.GEN_vPCODE_DeclarationGlobales(pcode,WD_tabParam);
int WD_ntabParamLen = 0;
if(WD_tabParam!=null) WD_ntabParamLen = WD_tabParam.Length;


return new WDVoid("");
}



/**
 * Traitement: Fin d'initialisation de FEN_Menu
 */
protected override WDObjet GEN_vPCODE_Initialisation(PCodeEnCours pcode)
{
pcode.GEN_Libelle = "Fin d'initialisation de FEN_Menu";
base.GEN_vPCODE_Initialisation(pcode);

// info("Authentification réussie")
APIIHMCore.GEN_Info("Authentification réussie");

// ZoneRépétéeAjouteLigne(ZR_Menu)
APIChampZR.GEN_ZoneRepeteeAjouteLigne(mWD_ZR_Menu);

return new WDVoid("GEN_vPCODE_Initialisation");
}


protected override void GEN_vDeclareProcedures()
{
}

// Activation des écouteurs: 
protected void _ActiveEcoute()
{
}

////////////////////////////////////////////////////////////////////////////
// Déclaration des variables globales
////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////
// Création des champs de la fenêtre FEN_Menu
////////////////////////////////////////////////////////////////////////////
protected override void GEN_vCreeChamp()
{
mWD_GR_Elements = new GWDGR_Elements();
mWD_GR_Boutons = new GWDGR_Boutons();
mWD_GR_Checkbox = new GWDGR_Checkbox();
mWD_ZR_Menu = new GWDZR_Menu();
mWD_BTN_Annuler = new GWDBTN_Annuler();
mWD_BTN_Valider = new GWDBTN_Valider();
mWD_Ajouter_une_visite = new GWDMAjouter_une_visite();

}
////////////////////////////////////////////////////////////////////////////
// Initialisation de la fenêtre FEN_Menu
////////////////////////////////////////////////////////////////////////////
protected  override void GEN_vInitialiserObjet()
{
GEN_QUID = 9596897664ul;
GEN_CheckSum = "758306567";
GEN_Nom = "FEN_Menu";
GEN_Type = 1;
SetPropriete(WDObjet.EPROPRIETE.PropNote, (new WDChaine("")));
SetPropriete(WDObjet.EPROPRIETE.PropTitreNote, (new WDChaine("")));
GEN_OrientationSupportee = 2;
GEN_AscenseursAuto = true;
GEN_SetModeOuverture(2);
GEN_SetTailleTotale(320, 566);
SetPropriete(WDObjet.EPROPRIETE.PropCouleurFond, (new WDEntier(16777215)));

_ActiveEcoute();


////////////////////////////////////////////////////////////////////////////
// Initialisation des groupes de champs de FEN_Menu
////////////////////////////////////////////////////////////////////////////
mWD_GR_Elements.Racine = Racine;
mWD_GR_Elements.Parent = this;
mWD_GR_Elements.GEN_Parent = this;
GEN_AjouteGroupeChamps(mWD_GR_Elements);
mWD_GR_Boutons.Racine = Racine;
mWD_GR_Boutons.Parent = this;
mWD_GR_Boutons.GEN_Parent = this;
GEN_AjouteGroupeChamps(mWD_GR_Boutons);
mWD_GR_Checkbox.Racine = Racine;
mWD_GR_Checkbox.Parent = this;
mWD_GR_Checkbox.GEN_Parent = this;
GEN_AjouteGroupeChamps(mWD_GR_Checkbox);


////////////////////////////////////////////////////////////////////////////
// Initialisation des champs de FEN_Menu
////////////////////////////////////////////////////////////////////////////
mWD_ZR_Menu.Racine = Racine;
mWD_ZR_Menu.Parent = this;
mWD_ZR_Menu.GEN_Parent = this;
GEN_AjouteChamp(mWD_ZR_Menu);
mWD_BTN_Annuler.Racine = Racine;
mWD_BTN_Annuler.Parent = this;
mWD_BTN_Annuler.GEN_Parent = this;
GEN_AjouteChamp(mWD_BTN_Annuler);
mWD_BTN_Valider.Racine = Racine;
mWD_BTN_Valider.Parent = this;
mWD_BTN_Valider.GEN_Parent = this;
GEN_AjouteChamp(mWD_BTN_Valider);
mWD_Ajouter_une_visite.Racine = Parent.Racine;
mWD_Ajouter_une_visite.Parent = this;
mWD_Ajouter_une_visite.GEN_Parent = this;
GEN_AjouteMenuPrincipal(mWD_Ajouter_une_visite);


}
}
}
