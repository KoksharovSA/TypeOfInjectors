using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfInjectors
{
    internal interface IInjector
    {
        //Сырая линия
        /// <summary>
        /// Заготовка
        /// </summary>
        /// <param name="length_detail">Длина детали</param>
        /// <returns>Возвращает длину заготовки</returns>
        float Blank(float length_detail);

        /// <summary>
        /// Бесцентровая шлифовка стаканчика
        /// </summary>
        /// <returns>Возвращает диаметр стаканчика</returns>
        float GrindingCup();

        /// <summary>
        /// Токарная Rika
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] TurningRIKA(params float[] sizes);

        /// <summary>
        /// Агрегатно-сверлильная Micron
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] AggregateDrillingMicron(params float[] sizes);

        /// <summary>
        /// Токарная опорный торец
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] TurningBearingButt();

        /// <summary>
        /// Агрегатно-сверлильная штифтовые и топливоподвод
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] AggregateDrillingUnis(params float[] sizes);

        /// <summary>
        /// Электрохимическая карман
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] ElectrochemicalPocket(params float[] sizes);

        /// <summary>
        /// Контрольная операция сырая линия (перед ТО)
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] ControlOperationRaw(params float[] sizes);

        //Калёная линия

        /// <summary>
        /// Шлифовка фаски предварительная
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingChamferPreliminary();

        /// <summary>
        /// Шлифовка стаканчика окончательная
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingCupFinal();

        /// <summary>
        /// Шлифовка профиля
        /// </summary>
        /// <param name="size7or9">Носик диаметр 7 или 9</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingProfile(int size7or9);

        /// <summary>
        /// Шлифовка сферы
        /// </summary>
        /// <param name="sizes"></param>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingSphere(params float[] sizes);

        /// <summary>
        /// Шлифовка фаски окончательная
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingChamferFinal();

        /// <summary>
        /// Маркировка
        /// </summary>
        /// <param name="data_marking">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        string[] Marking(params string[] data_marking);

        /// <summary>
        /// Внутренняя шлифовка UVA
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] GrindingUVA(params float[] sizes);

        /// <summary>
        /// Прошивка сопловых отверстий
        /// </summary>
        /// <param name="size_broach">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] Broach(params float[] size_broach);

        /// <summary>
        /// Гидрополировка сопловых отверстий
        /// </summary>
        /// <param name="consuption">Данные расхода</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] Polishing(params float[] consuption);

        /// <summary>
        /// Контрольная операция калёная линия(после ТО)
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] ControlOperationHardy(params float[] sizes);

        /// <summary>
        /// Сборка
        /// </summary>
        /// <param name="needle">Игла</param>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        object[] Assembly(string needle, params float[] sizes);

        /// <summary>
        /// Контрольная операция сборка
        /// </summary>
        /// <param name="sizes">Массив параметров</param>
        /// <returns>Возвращает массив размеров</returns>
        float[] ControlOperationFinal(params float[] sizes);
    }

    internal interface IInjector7
    {
        /// <summary>
        /// Токаркная диаметр 7 сырая линия 
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] Turning7();
    }

    internal interface IInjectorMandrel
    {
        /// <summary>
        /// Дорнование
        /// </summary>
        /// <returns>Возвращает массив размеров</returns>
        float[] Mandrel();
    }

    public class Detail
    {
        /// <summary>
        /// Название детали
        /// </summary>
        public string Name_detail { get; set; }

        /// <summary>
        /// Индекс детали
        /// </summary>
        public string Index_detail { get; set; }

        /// <summary>
        /// Тип детали
        /// </summary>
        public string Type_detail { get; set; }

        /// <summary>
        /// Описание детали
        /// </summary>
        public string Description_detail { get; set; }

        /// <summary>
        /// Материал детали
        /// </summary>
        public string Material { get; set; }

        /// <summary>
        /// Номер технологического процесса сырая линия
        /// </summary>
        public string ProcessNumberRaw { get; set; }

        /// <summary>
        /// Номер технологического процесса калёная линия
        /// </summary>
        public string ProcessNumberHardy { get; set; }

        /// <summary>
        /// Номер технологического процесса сборка
        /// </summary>
        public string ProcessNumberAssembly { get; set; }

        public Detail()
        {
            Name_detail = "";
            Index_detail = "";
            Type_detail = "";
            Material = "";
            Description_detail = "";
            ProcessNumberRaw = "";
            ProcessNumberHardy = "";
            ProcessNumberAssembly = "";
        }

        public Detail(string name_detail, string index_detail, string type_detail, string description_detail, string material, string processNumberRaw, string processNumberHardy, string processNumberAssembly)
        {
            Name_detail = name_detail ?? throw new ArgumentNullException(nameof(name_detail));
            Index_detail = index_detail ?? throw new ArgumentNullException(nameof(index_detail));
            Type_detail = type_detail ?? throw new ArgumentNullException(nameof(type_detail));
            Description_detail = description_detail ?? throw new ArgumentNullException(nameof(description_detail));
            Material = material ?? throw new ArgumentNullException(nameof(material));
            ProcessNumberRaw = processNumberRaw ?? throw new ArgumentNullException(nameof(processNumberRaw));
            ProcessNumberHardy = processNumberHardy ?? throw new ArgumentNullException(nameof(processNumberHardy));
            ProcessNumberAssembly = processNumberAssembly ?? throw new ArgumentNullException(nameof(processNumberAssembly));
        }

        public string Data_detail()
        {
            string data = Name_detail + "\n" + Index_detail + "\n" + Type_detail + "\n" + Description_detail + "\n" + ProcessNumberRaw + "\n" + ProcessNumberHardy + "\n" + ProcessNumberAssembly;
            return data;
        }
    }

    public static class Allowances
    {
        /// <summary>
        /// Припуск на торец Rika
        /// </summary>
        public static float allowanceButtRika;

        /// <summary>
        /// Припуск на опорный торец
        /// </summary>
        public static float allowanceBearingButt;

        /// <summary>
        /// Припуск на диаметр стаканчика
        /// </summary>
        public static float allowanceDiameterCup;

        /// <summary>
        /// Припуск на сферу
        /// </summary>
        public static float allowanceSphere;

        /// <summary>
        /// Припуск на угол 59
        /// </summary>
        public static float allowanceAngle59;

        /// <summary>
        /// Припуск на диаметр 4
        /// </summary>
        public static float allowanceDiameter4;
    }

    public class InjectorSize
    {
        public InjectorSize()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="diameterCup">Диаметр стаканчика</param>
        /// <param name="lengthCup">Длина стаканчика</param>
        /// <param name="angleChamferCup"></param>
        /// <param name="lengthChamferCup"></param>
        /// <param name="lengthOverall"></param>
        /// <param name="diameterNose"></param>
        /// <param name="angleShoulder"></param>
        /// <param name="angleNose"></param>
        /// <param name="lengthShoulderCaliber625"></param>
        /// <param name="radiusShoulderNose"></param>
        /// <param name="radiusNose"></param>
        /// <param name="diameterRecess"></param>
        /// <param name="lengthRecess"></param>
        /// <param name="angleRecess"></param>
        /// <param name="radiusRecess"></param>
        /// <param name="diameterPocket"></param>
        /// <param name="lengthPocket"></param>
        /// <param name="radiusRidgepoleFuelSupply"></param>
        /// <param name="diameterFuelSupply"></param>
        /// <param name="lengthFuelSupply"></param>
        /// <param name="radiusRidgepolePinhole"></param>
        /// <param name="diameterPinhole"></param>
        /// <param name="lengthPinhole"></param>
        /// <param name="angleWidthPinhole"></param>
        /// <param name="lengthBeforeAngle34"></param>
        /// <param name="lengthBeforeCaliber2"></param>
        /// <param name="lengthFromCaliber2BeforeWell"></param>
        /// <param name="diameterWell"></param>
        /// <param name="diametrCenterHole">Диаметр центрального отверстия</param>
        /// <param name="diametreNozzleHole">Диаметр сопловых отверстий</param>
        /// <param name="angleAlpha1">Угол Альфа1</param>
        /// <param name="angleAlpha2">Угол Альфа2</param>
        /// <param name="angleAlpha3">Угол Альфа3</param>
        /// <param name="angleAlpha4">Угол Альфа4</param>
        /// <param name="angleAlpha5">Угол Альфа5</param>
        /// <param name="angleAlpha6">Угол Альфа6</param>
        /// <param name="angleAlpha7">Угол Альфа7</param>
        /// <param name="angleAlpha8">Угол Альфа8</param>
        /// <param name="angleAlpha9">Угол Альфа9</param>
        /// <param name="angleAlpha10">Угол Альфа10</param>
        /// <param name="anglePhi1">Угол Фи1</param>
        /// <param name="anglePhi2">Угол Фи2</param>
        /// <param name="anglePhi3">Угол Фи3</param>
        /// <param name="anglePhi4">Угол Фи4</param>
        /// <param name="anglePhi5">Угол Фи5</param>
        /// <param name="anglePhi6">Угол Фи6</param>
        /// <param name="anglePhi7">Угол Фи7</param>
        /// <param name="anglePhi8">Угол Фи8</param>
        /// <param name="anglePhi9">Угол Фи9</param>
        /// <param name="anglePhi10">Угол Фи10</param>
        /// <param name="kiFromCaliber2_1">Ki от 2 - 1</param>
        /// <param name="kiFromCaliber2_2">Ki от 2 - 2</param>
        /// <param name="kiFromCaliber2_3">Ki от 2 - 3</param>
        /// <param name="kiFromCaliber2_4">Ki от 2 - 4</param>
        /// <param name="kiFromCaliber2_5">Ki от 2 - 5</param>
        /// <param name="kiFromCaliber2_6">Ki от 2 - 6</param>
        /// <param name="kiFromCaliber2_7">Ki от 2 - 7</param>
        /// <param name="kiFromCaliber2_8">Ki от 2 - 8</param>
        /// <param name="kiFromCaliber2_9">Ki от 2 - 9</param>
        /// <param name="kiFromCaliber2_10">Ki от 2 - 10</param>
        /// <param name="percentHydropolishing"></param>
        /// <param name="percentThrottling"></param>
        /// <param name="hydrodensityDown"></param>
        /// <param name="hydrodensityUp"></param>
        /// <param name="drowningNeedle"></param>
        /// <param name="drowningNeedleLimitDown"></param>
        /// <param name="drowningNeedleLimitUp"></param>
        /// <param name="protrusionShank"></param>
        /// <param name="protrusionShankLimitDown"></param>
        /// <param name="protrusionShankLimitUp"></param>
        /// <param name="rateSonplasMinInTheCollection"></param>
        /// <param name="rateSonplasMaxInTheCollection"></param>
        /// <param name="rateMfMinInTheCollection"></param>
        /// <param name="rateMfMaxInTheCollection"></param>
        public InjectorSize(float diameterCup, float lengthCup, float angleChamferCup, float lengthChamferCup, float lengthOverall, float diameterNose, float angleShoulder, float angleNose, float lengthShoulderCaliber625, float radiusShoulderNose, float radiusNose, float diameterRecess, float lengthRecess, float angleRecess, float radiusRecess, float diameterPocket, float lengthPocket, float radiusRidgepoleFuelSupply, float diameterFuelSupply, float lengthFuelSupply, float radiusRidgepolePinhole, float diameterPinhole, float lengthPinhole, float angleWidthPinhole, float lengthBeforeAngle34, float lengthBeforeCaliber2, float lengthFromCaliber2BeforeWell, float diameterWell, float diametrCenterHole, float diametreNozzleHole, float angleAlpha1, float angleAlpha2, float angleAlpha3, float angleAlpha4, float angleAlpha5, float angleAlpha6, float angleAlpha7, float angleAlpha8, float angleAlpha9, float angleAlpha10, float anglePhi1, float anglePhi2, float anglePhi3, float anglePhi4, float anglePhi5, float anglePhi6, float anglePhi7, float anglePhi8, float anglePhi9, float anglePhi10, float kiFromCaliber2_1, float kiFromCaliber2_2, float kiFromCaliber2_3, float kiFromCaliber2_4, float kiFromCaliber2_5, float kiFromCaliber2_6, float kiFromCaliber2_7, float kiFromCaliber2_8, float kiFromCaliber2_9, float kiFromCaliber2_10, float percentHydropolishing, float percentThrottling, float hydrodensityDown, float hydrodensityUp, float drowningNeedle, float drowningNeedleLimitDown, float drowningNeedleLimitUp, float protrusionShank, float protrusionShankLimitDown, float protrusionShankLimitUp, float rateSonplasMinInTheCollection, float rateSonplasMaxInTheCollection, float rateMfMinInTheCollection, float rateMfMaxInTheCollection)
        {
            DiameterCup = diameterCup;
            LengthCup = lengthCup;
            AngleChamferCup = angleChamferCup;
            LengthChamferCup = lengthChamferCup;
            LengthOverall = lengthOverall;
            DiameterNose = diameterNose;
            AngleShoulder = angleShoulder;
            AngleNose = angleNose;
            LengthShoulderCaliber625 = lengthShoulderCaliber625;
            RadiusShoulderNose = radiusShoulderNose;
            RadiusNose = radiusNose;
            DiameterRecess = diameterRecess;
            LengthRecess = lengthRecess;
            AngleRecess = angleRecess;
            RadiusRecess = radiusRecess;
            DiameterPocket = diameterPocket;
            LengthPocket = lengthPocket;
            RadiusRidgepoleFuelSupply = radiusRidgepoleFuelSupply;
            DiameterFuelSupply = diameterFuelSupply;
            LengthFuelSupply = lengthFuelSupply;
            RadiusRidgepolePinhole = radiusRidgepolePinhole;
            DiameterPinhole = diameterPinhole;
            LengthPinhole = lengthPinhole;
            AngleWidthPinhole = angleWidthPinhole;
            LengthBeforeAngle34 = lengthBeforeAngle34;
            LengthBeforeCaliber2 = lengthBeforeCaliber2;
            LengthFromCaliber2BeforeWell = lengthFromCaliber2BeforeWell;
            DiameterWell = diameterWell;
            DiametrCenterHole = diametrCenterHole;
            DiametreNozzleHole = diametreNozzleHole;
            AngleAlpha1 = angleAlpha1;
            AngleAlpha2 = angleAlpha2;
            AngleAlpha3 = angleAlpha3;
            AngleAlpha4 = angleAlpha4;
            AngleAlpha5 = angleAlpha5;
            AngleAlpha6 = angleAlpha6;
            AngleAlpha7 = angleAlpha7;
            AngleAlpha8 = angleAlpha8;
            AngleAlpha9 = angleAlpha9;
            AngleAlpha10 = angleAlpha10;
            AnglePhi1 = anglePhi1;
            AnglePhi2 = anglePhi2;
            AnglePhi3 = anglePhi3;
            AnglePhi4 = anglePhi4;
            AnglePhi5 = anglePhi5;
            AnglePhi6 = anglePhi6;
            AnglePhi7 = anglePhi7;
            AnglePhi8 = anglePhi8;
            AnglePhi9 = anglePhi9;
            AnglePhi10 = anglePhi10;
            KiFromCaliber2_1 = kiFromCaliber2_1;
            KiFromCaliber2_2 = kiFromCaliber2_2;
            KiFromCaliber2_3 = kiFromCaliber2_3;
            KiFromCaliber2_4 = kiFromCaliber2_4;
            KiFromCaliber2_5 = kiFromCaliber2_5;
            KiFromCaliber2_6 = kiFromCaliber2_6;
            KiFromCaliber2_7 = kiFromCaliber2_7;
            KiFromCaliber2_8 = kiFromCaliber2_8;
            KiFromCaliber2_9 = kiFromCaliber2_9;
            KiFromCaliber2_10 = kiFromCaliber2_10;
            PercentHydropolishing = percentHydropolishing;
            PercentThrottling = percentThrottling;
            HydrodensityDown = hydrodensityDown;
            HydrodensityUp = hydrodensityUp;
            DrowningNeedle = drowningNeedle;
            DrowningNeedleLimitDown = drowningNeedleLimitDown;
            DrowningNeedleLimitUp = drowningNeedleLimitUp;
            ProtrusionShank = protrusionShank;
            ProtrusionShankLimitDown = protrusionShankLimitDown;
            ProtrusionShankLimitUp = protrusionShankLimitUp;
            RateSonplasMinInTheCollection = rateSonplasMinInTheCollection;
            RateSonplasMaxInTheCollection = rateSonplasMaxInTheCollection;
            RateMfMinInTheCollection = rateMfMinInTheCollection;
            RateMfMaxInTheCollection = rateMfMaxInTheCollection;
        }

        /// <summary>
        /// Диаметр стаканчика
        /// </summary>
        public float DiameterCup { get; set; }

        /// <summary>
        /// Длина стаканчика
        /// </summary>
        public float LengthCup { get; set; }

        /// <summary>
        /// Угол фаски стаканчика
        /// </summary>
        public float AngleChamferCup { get; set; }

        /// <summary>
        /// Длина фаски стаканчика
        /// </summary>
        public float LengthChamferCup { get; set; }

        /// <summary>
        /// Длина распылителя (габарит)
        /// </summary>
        public float LengthOverall { get; set; }

        /// <summary>
        /// Диаметр носика
        /// </summary>
        public float DiameterNose { get; set; }

        /// <summary>
        /// Угол плечиков
        /// </summary>
        public float AngleShoulder { get; set; }

        /// <summary>
        /// Угол носика
        /// </summary>
        public float AngleNose { get; set; }

        /// <summary>
        /// Длина от носика до калибра 6,25
        /// </summary>
        public float LengthShoulderCaliber625 { get; set; }

        /// <summary>
        /// Радиус скругления плечи > носик
        /// </summary>
        public float RadiusShoulderNose { get; set; }

        /// <summary>
        /// Радиус носика
        /// </summary>
        public float RadiusNose { get; set; }

        /// <summary>
        /// Диаметр нерабочей выточки
        /// </summary>
        public float DiameterRecess { get; set; }

        /// <summary>
        /// Длина нерабочей выточки
        /// </summary>
        public float LengthRecess { get; set; }

        /// <summary>
        /// Угол нерабочей выточки
        /// </summary>
        public float AngleRecess { get; set; }

        /// <summary>
        /// Скругление нерабочей выточки
        /// </summary>
        public float RadiusRecess { get; set; }

        /// <summary>
        /// Диаметр кармана
        /// </summary>
        public float DiameterPocket { get; set; }

        /// <summary>
        /// Длина до кармана
        /// </summary>
        public float LengthPocket { get; set; }

        /// <summary>
        /// Радиус растяжки топливопровода
        /// </summary>
        public float RadiusRidgepoleFuelSupply { get; set; }

        /// <summary>
        /// Диаметр топливоподвода
        /// </summary>
        public float DiameterFuelSupply { get; set; }

        /// <summary>
        /// Длина топливоподвода
        /// </summary>
        public float LengthFuelSupply { get; set; }

        /// <summary>
        /// Радиус растяжки штифтовых отверстий
        /// </summary>
        public float RadiusRidgepolePinhole { get; set; }

        /// <summary>
        /// Диаметр штифтовых отверстий
        /// </summary>
        public float DiameterPinhole { get; set; }

        /// <summary>
        /// Глубина штифтовых отверстий
        /// </summary>
        public float LengthPinhole { get; set; }

        /// <summary>
        /// Угол между штифтовыми отверстиями
        /// </summary>
        public float AngleWidthPinhole { get; set; }

        /// <summary>
        /// Длина до калибра 3,4
        /// </summary>
        public float LengthBeforeAngle34 { get; set; }

        /// <summary>
        /// Длина до калибра 2
        /// </summary>
        public float LengthBeforeCaliber2 { get; set; }

        /// <summary>
        /// Длина от калибра 2 до дна колодца
        /// </summary>
        public float LengthFromCaliber2BeforeWell { get; set; }

        /// <summary>
        /// Диаметр колодца
        /// </summary>
        public float DiameterWell { get; set; }

        /// <summary>
        /// Диаметр центрального отверстия
        /// </summary>
        public float DiametrCenterHole { get; set; }

        /// <summary>
        /// Диаметр сопловых отверстий
        /// </summary>
        public float DiametreNozzleHole { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha1 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha2 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha3 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha4 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha5 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha6 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha7 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha8 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha9 { get; set; }

        /// <summary>
        /// Угол альфа
        /// </summary>
        public float AngleAlpha10 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi1 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi2 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi3 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi4 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi5 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi6 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi7 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi8 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float AnglePhi9 { get; set; }

        /// <summary>
        /// Угол фи
        /// </summary>
        public float AnglePhi10 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_1 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_2 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_3 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_4 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_5 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_6 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_7 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_8 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_9 { get; set; }

        /// <summary>
        /// Ki от калибра 2
        /// </summary>
        public float KiFromCaliber2_10 { get; set; }

        /// <summary>
        /// Процент гидрополировки
        /// </summary>
        public float PercentHydropolishing { get; set; }

        /// <summary>
        /// Процент дросселированния 
        /// </summary>
        public float PercentThrottling { get; set; }

        /// <summary>
        /// Гидроплотность низ
        /// </summary>
        public float HydrodensityDown { get; set; }

        /// <summary>
        /// Гидроплотность верх
        /// </summary>
        public float HydrodensityUp { get; set; }

        /// <summary>
        /// Утопание иглы
        /// </summary>
        public float DrowningNeedle { get; set; }

        /// <summary>
        /// Утопание иглы допуск низ
        /// </summary>
        public float DrowningNeedleLimitDown { get; set; }

        /// <summary>
        /// Утопание иглы допуск верх
        /// </summary>
        public float DrowningNeedleLimitUp { get; set; }

        /// <summary>
        /// Выступание хвостовика 
        /// </summary>
        public float ProtrusionShank { get; set; }

        /// <summary>
        /// Выступание хвостовика допуск низ
        /// </summary>
        public float ProtrusionShankLimitDown { get; set; }

        /// <summary>
        /// Выступание хвостовика допуск верх
        /// </summary>
        public float ProtrusionShankLimitUp { get; set; }

        /// <summary>
        /// Расход Sonplas в сборе низ
        /// </summary>
        public float RateSonplasMinInTheCollection { get; set; }

        /// <summary>
        /// Расход Sonplas в сборе верх
        /// </summary>
        public float RateSonplasMaxInTheCollection { get; set; }

        /// <summary>
        /// Расход Mf в сборе низ
        /// </summary>
        public float RateMfMinInTheCollection { get; set; }

        /// <summary>
        /// Расход Mf в сборе верх
        /// </summary>
        public float RateMfMaxInTheCollection { get; set; }

    }

    public class Injector9notMandrel : IInjector
    {
        private readonly InjectorSize injectorSize;
        private readonly Detail detail;

        /// <summary>
        /// Конструктор класса распылителя 9 без дорна
        /// </summary>
        /// <param name="injector">Экземпляр класса чертёжных размеров распылителя</param>
        /// <param name="det">Экземпляр класса данных распылителя в сборе</param>
        public Injector9notMandrel(InjectorSize injector, Detail det)
        {
            injectorSize = injector;
            detail = det;
        }

        /// <summary>
        /// Токарная Rika
        /// </summary>
        /// <param name="sizes">
        /// 0 - Угол левой фаски;
        /// 1 - Длина левой фаски;
        /// 2 - Угол правой фаски;
        /// 3 - Длина правой фаски;
        /// 4 - Диаметр носика на Rika;
        /// </param>
        /// <returns>
        /// Возвращает массив размеров:
        /// 0 - Угол левой фаски 
        /// 1 - Длина левой фаски
        /// 2 - Угол правой фаски
        /// 3 - Длина правой фаски
        /// 4 - Длина стаканчика
        /// 5 - Длина от торца до калибра 8,5
        /// 6 - От носика до края плечиков
        /// 7 - угол плечиков
        /// 8 - Радиус скругления плечи носик
        /// 9 - Радиус сферы
        /// 10 - Диаметр стаканчика
        /// </returns>
        public float[] TurningRIKA(params float[] sizes)
        {
            float[] result = new float[10];

            result[0] = sizes[0];
            result[1] = sizes[1];
            result[2] = sizes[2];
            result[3] = sizes[3];
            result[4] = injectorSize.LengthCup + Allowances.allowanceButtRika + Allowances.allowanceBearingButt;
            float difference62585 = 0.41F; //разница между калибрами 6,25 и 8,5 на углу 140
            if (injectorSize.AngleShoulder == 120) difference62585 = 0.65F; //разница между калибрами 6,25 и 8,5 на углу 120
            result[5] = injectorSize.LengthOverall + Allowances.allowanceButtRika + Allowances.allowanceSphere - injectorSize.LengthShoulderCaliber625 - difference62585;
            float difference62594 = 0.57F; //разница между калибрами 6,25 и 9,4 на углу 140
            if (injectorSize.AngleShoulder == 120) difference62585 = 0.91F; //разница между калибрами 6,25 и 9,4 на углу 120
            result[6] = injectorSize.LengthShoulderCaliber625 + difference62594;
            result[7] = injectorSize.AngleShoulder;
            result[8] = injectorSize.RadiusShoulderNose;
            result[9] = injectorSize.RadiusNose + Allowances.allowanceSphere;
            result[10] = injectorSize.DiameterCup + Allowances.allowanceDiameterCup;
             
            return result;
        }

        /// <summary>
        /// Агрегатно-сверлильная Micron
        /// </summary>
        /// <param name="sizes">
        /// 0 - Угол > 59;
        /// 1 - Минуты угла 59 > 20;
        /// 3 - Съём с торца;
        /// 4 - Диаметр центрального отверстия(4);
        /// </param>
        /// <returns>
        /// Возвращает массив размеров:
        /// 0 - Длина стаканчика
        /// 1 - Длина от торца до калибра 3,4
        /// 2 - Длина от торца до калибра 2,2
        /// 3 - Длина от торца до дна колодца
        /// 4 - Длина от калибра 2,2 до дна колодца
        /// 5 - Диаметр колодца
        /// 6 - Диаметр нерабочей выточки
        /// 7 - Глубина нерабочей выточки
        /// 8 - Угол нерабочей выточки
        /// 9 - Скругление нерабочей выточки
        /// 10 - Угол внутреннего конуса
        /// 11 - Минуты угла внутреннего конуса
        /// 12 - Диаметр центрального отверстия(4)
        /// </returns>
        public float[] AggregateDrillingMicron(params float[] sizes)
        {
            float[] result = new float[13];

            result[0] = injectorSize.LengthCup + Allowances.allowanceButtRika + Allowances.allowanceBearingButt - sizes[3];
            result[1] = injectorSize.LengthBeforeAngle34 + Allowances.allowanceButtRika - sizes[3];
            result[2] = injectorSize.LengthBeforeCaliber2 + Allowances.allowanceButtRika - sizes[3] - 0.176F - Allowances.allowanceAngle59;
            result[3] = injectorSize.LengthBeforeCaliber2 + injectorSize.LengthFromCaliber2BeforeWell + Allowances.allowanceButtRika - sizes[3];
            result[5] = injectorSize.DiameterWell;
            result[6] = injectorSize.DiameterRecess;
            result[7] = injectorSize.LengthRecess + Allowances.allowanceButtRika - sizes[3];
            result[8] = injectorSize.AngleRecess;
            result[9] = injectorSize.RadiusRecess;
            result[10] = sizes[0];
            result[11] = sizes[1];
            result[12] = injectorSize.DiametrCenterHole - Allowances.allowanceDiameter4;
            
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sizes"></param>
        /// 0 - Съём с торца на Micron;
        /// 1 - Минуты угла 59 > 20;
        /// 3 - Съём с торца;
        /// 4 - Диаметр центрального отверстия(4);
        /// </param>
        /// <returns>
        /// Возвращает массив размеров:
        /// 0 - Длина стаканчика
        /// 1 - Длина от торца до калибра 3,4
        /// 2 - Длина от торца до калибра 2,2
        /// 3 - Длина от торца до дна колодца
        /// 4 - Длина от калибра 2,2 до дна колодца
        /// 5 - Диаметр колодца
        /// 6 - Диаметр нерабочей выточки
        /// 7 - Глубина нерабочей выточки
        /// 8 - Угол нерабочей выточки
        /// </returns>
        public float[] AggregateDrillingUnis(params float[] sizes)
        {
            float[] result = new float[13];

            result[0] = injectorSize.DiameterFuelSupply;
            result[1] = injectorSize.LengthFuelSupply + Allowances.allowanceButtRika - sizes[0];
            result[2] = 1;

            return result;
            throw new NotImplementedException();
        }

        public object[] Assembly(string needle, params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float Blank(float length_detail)
        {
            throw new NotImplementedException();
        }

        public float[] Broach(params float[] size_broach)
        {
            throw new NotImplementedException();
        }

        public float[] ControlOperationFinal(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float[] ControlOperationHardy(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float[] ControlOperationRaw(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float[] ElectrochemicalPocket(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float[] GrindingChamferFinal()
        {
            throw new NotImplementedException();
        }

        public float[] GrindingChamferPreliminary()
        {
            throw new NotImplementedException();
        }

        public float GrindingCup()
        {
            throw new NotImplementedException();
        }

        public float[] GrindingCupFinal()
        {
            throw new NotImplementedException();
        }

        public float[] GrindingProfile(int size7or9)
        {
            throw new NotImplementedException();
        }

        public float[] GrindingSphere(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public float[] GrindingUVA(params float[] sizes)
        {
            throw new NotImplementedException();
        }

        public string[] Marking(params string[] data_marking)
        {
            throw new NotImplementedException();
        }

        public float[] Polishing(params float[] consuption)
        {
            throw new NotImplementedException();
        }

        public float[] TurningBearingButt()
        {
            throw new NotImplementedException();
        }       
    }
}
