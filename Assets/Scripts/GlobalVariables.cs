public static class GlobalVariables
{
    private static int darkMaterialAmount;

    public static int DarkMaterial
    {
        get => darkMaterialAmount;
        set
        {
            darkMaterialAmount = value;
            UIManager.Instance.UpdateDarkMaterialTextUI(darkMaterialAmount);
        }
    }
}
