namespace LiturgiaDasHoras
{
    public class EnumToStoleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Stole estola)
            {
                switch (estola)
                {
                    case Stole.Branca:
                        return "estola_branco.png";
                    case Stole.Creme:
                        return "estola_creme.png";
                    case Stole.Rosa:
                        return "estola_rosa.png";
                    case Stole.Roxa:
                        return "estola_roxo.png";
                    case Stole.Verde:
                        return "estola_verde.png";
                    case Stole.Vermelha:
                        return "estola_vermelho.png";
                    default:
                        return "estola_verde.png";
                }
            }
            return "estola_verde.png";
        }
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StoleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Stole estola)
            {
                
                switch (estola)
                {
                    case Stole.Branca:
                        return $"#FFFFFF"; 
                    case Stole.Creme:
                        return $"#FFF9EB";
                    case Stole.Rosa:                                    
                        return $"#FFBAE0";
                    case Stole.Roxa:                                    
                        return $"#403152";
                    case Stole.Verde:                                   
                        return $"#007834";
                    case Stole.Vermelha:                                
                        return $"#C00000";
                    default:                                            
                        return $"#007834";
                }
            }
            return $"#007834";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool val && parameter is bool param)
            {
                if (!param) return param;
                return !val;
            }
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
