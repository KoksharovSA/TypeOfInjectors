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
        double Blank(double length_detail);
        double GrindingCup();
        double[] TurningRIKA(params double[] sizes);
        double[] AggregateDrillingMicron(params double[] sizes);
        double[] TurningBearingButt();
        double[] AggregateDrillingUnis(params double[] sizes);
        double[] ElectrochemicalPocket(params double[] sizes);
        double[] ControlOperationRaw(params double[] sizes);
        //Калёная линия
        double[] GrindingChamferPreliminary();
        double[] GrindingCupFinal();
        double[] GrindingProfile(int size7or9);
        double[] GrindingSphere(params double[] sizes);
        double[] GrindingChamferFinal();
        string[] Marking(params string[] data_marking);
        double[] GrindingUVA(params double[] sizes);
        double[] Broach(params double[] size_broach);
        double[] Polishing(params double[] consuption);
        double[] ControlOperationHardy(params double[] sizes);
        object[] Assembly(string needle, params double[] sizes);
        double[] ControlOperationFinal(params double[] sizes);
    }

    internal interface IInjector7
    {
        double[] Turning7();
    }

    internal interface IInjectorMandrel
    {
        double[] Mandrel();
    }

    public class Detail
    {
        private string name_detail;
        private string index_detail;
        private string type_detail;
        private string material;
        private string description_detail;
        private string processNumberRaw;
        private string processNumberHardy;

        public string Name_detail { get => name_detail; set => name_detail = value; }
        public string Index_detail { get => index_detail; set => index_detail = value; }
        public string Type_detail { get => type_detail; set => type_detail = value; }
        public string Description_detail { get => description_detail; set => description_detail = value; }
        public string Material { get => material; set => material = value; }
        public string ProcessNumberRaw { get => processNumberRaw; set => processNumberRaw = value; }
        public string ProcessNumberHardy { get => processNumberHardy; set => processNumberHardy = value; }

        public Detail()
        {
            Name_detail = "";
            Index_detail = "";
            Type_detail = "";
            Material = "";
            Description_detail = "";
            ProcessNumberRaw = "";
            ProcessNumberHardy = "";
        }

        public Detail(string name_detail, string index_detail, string type_detail, string material, string description_detail)
        {
            Name_detail = name_detail;
            Index_detail = index_detail;
            Type_detail = type_detail;
            Material = material;
            Description_detail = description_detail;
            ProcessNumberRaw = processNumberRaw;
            ProcessNumberHardy = processNumberHardy;

        }

        public string Data_detail()
        {
            string data = Name_detail + "\n" + Index_detail + "\n" + Type_detail + "\n" + Description_detail + "\n" + ProcessNumberRaw + "\n" + ProcessNumberHardy;
            return data;
        }
    }

    public class Allowances
    {
        private double allowanceButt; //Припуск на торец
        private double allowanceBearingButt; //Припуск на опорный торец
        private double allowanceDiameterCup; //Припуск на диаметр стаканчика
        private double allowanceSphere; //Припуск на сферу
        private double allowanceAngle59; //Припуск на угол 59
        private double allowanceDiameter4; //Припуск на диаметр 4

    }

    public class InjectorSize
    {
        //Размеры распылителя
        private double diameterCup; //Диаметр стаканчика
        private double lengthCup; //Длина стаканчика
        private double angleChamferCup; //Угол фаски стаканчика
        private double lengthChamferCup; //Длина фаски
        private double lengthOverall; //Длина распылителя(габарит)
        private double diameterNose; //Диаметр носика
        private double angleShoulder; //Угол плечиков
        private double angleNose; //угол носика
        private double lengthShoulderCaliber625; //Длина от носика до калибра 6,25
        private double radiusShoulderNose; //Радиус скругления плечи > носик
        private double radiusNose; //Радиус носика
        private double diameterRecess; //Диаметр нерабочей выточки
        private double lengthRecess; //Длина нерабочей выточки
        private double diameterPocket; //Диаметр кармана
        private double lengthPocket; //Длинна до кармана
        private double radiusRidgepoleFuelSupply; //Радиус растяжки топливоподвода
        private double diameterFuelSupply; //Диаметр топливоподвода
        private double lengthFuelSupply; //Длина топливоподвода
        private double radiusRidgepolePinhole; //Радиус растяжки штифтовых отверстий
        private double diameterPinhole; // Диаметр штифтовых отверстий
        private double lengthPinhole; //Длина штифтовых отверстий(глубина)
        private double angleWidthPinhole; //Угол между штифтовыми отверстиями
        private double lengthBeforeAngle90; //Длина до угла 90
        private double lengthBeforeCaliber2; //Длина до калибра 2
        private double lengthFromCaliber2BeforeWell; //Длина от калибра 2 до дна колодца
        private double diameterWell; //Диаметр колодца
        
        //Параметры прошивки
        private double diametreNozzleHole; //Диаметр сопловых отверстий
        private double angleAlpha1; //Угол альфа
        private double angleAlpha2;
        private double angleAlpha3;
        private double angleAlpha4;
        private double angleAlpha5;
        private double angleAlpha6;
        private double angleAlpha7;
        private double angleAlpha8;
        private double angleAlpha9;
        private double angleAlpha10;
        private double anglePhi1; //Угол фи
        private double anglePhi2;
        private double anglePhi3;
        private double anglePhi4;
        private double anglePhi5;
        private double anglePhi6;
        private double anglePhi7;
        private double anglePhi8;
        private double anglePhi9;
        private double anglePhi10;
        private double KiFromCaliber2_1; //Ki от калибра 2
        private double KiFromCaliber2_2;
        private double KiFromCaliber2_3;
        private double KiFromCaliber2_4;
        private double KiFromCaliber2_5;
        private double KiFromCaliber2_6;
        private double KiFromCaliber2_7;
        private double KiFromCaliber2_8;
        private double KiFromCaliber2_9;
        private double KiFromCaliber2_10;
        private double percentHydropolishing; //Процент гидрополировки
        private double percentThrottling; //Процент дросселирования иглой

        //Параметры сборки
        private double hydrodensityDown; //Гидроплотность низ
        private double hydrodensityUp; //Гидроплотность верх
        private double drowningNeedle; //Утопание иглы
        private double drowningNeedleLimitDown; //Утопание иглы допуск низ
        private double drowningNeedleLimitUp; //Утопание иглы допуск верх
        private double protrusionShank; //Выступание хвостовика
        private double protrusionShankLimitDown; //Выступание хвостовика допуск низ
        private double protrusionShankLimitUp; //Выступание хвостовика допуск верх
        private double rateSonplasMinInTheCollection; //Расход Sonplas в сборе
        private double rateSonplasMaxInTheCollection;
        private double rateMfMinInTheCollection; //Расход Mf в сборе
        private double rateMfMaxInTheCollection;

        public InjectorSize()
        {
        }

        public double DiameterCup { get => diameterCup; set => diameterCup = value; }
        public double LengthCup { get => lengthCup; set => lengthCup = value; }
        public double AngleChamferCup { get => angleChamferCup; set => angleChamferCup = value; }
        public double LengthChamferCup { get => lengthChamferCup; set => lengthChamferCup = value; }
        public double LengthOverall { get => lengthOverall; set => lengthOverall = value; }
        public double DiameterNose { get => diameterNose; set => diameterNose = value; }
        public double AngleShoulder { get => angleShoulder; set => angleShoulder = value; }
        public double AngleNose { get => angleNose; set => angleNose = value; }
        public double LengthShoulderCaliber625 { get => lengthShoulderCaliber625; set => lengthShoulderCaliber625 = value; }
        public double RadiusShoulderNose { get => radiusShoulderNose; set => radiusShoulderNose = value; }
        public double RadiusNose { get => radiusNose; set => radiusNose = value; }
        public double DiameterRecess { get => diameterRecess; set => diameterRecess = value; }
        public double LengthRecess { get => lengthRecess; set => lengthRecess = value; }
        public double DiameterPocket { get => diameterPocket; set => diameterPocket = value; }
        public double LengthPocket { get => lengthPocket; set => lengthPocket = value; }
        public double RadiusRidgepoleFuelSupply { get => radiusRidgepoleFuelSupply; set => radiusRidgepoleFuelSupply = value; }
        public double DiameterFuelSupply { get => diameterFuelSupply; set => diameterFuelSupply = value; }
        public double LengthFuelSupply { get => lengthFuelSupply; set => lengthFuelSupply = value; }
        public double RadiusRidgepolePinhole { get => radiusRidgepolePinhole; set => radiusRidgepolePinhole = value; }
        public double DiameterPinhole { get => diameterPinhole; set => diameterPinhole = value; }
        public double LengthPinhole { get => lengthPinhole; set => lengthPinhole = value; }
        public double AngleWidthPinhole { get => angleWidthPinhole; set => angleWidthPinhole = value; }
        public double LengthBeforeAngle90 { get => lengthBeforeAngle90; set => lengthBeforeAngle90 = value; }
        public double LengthBeforeCaliber2 { get => lengthBeforeCaliber2; set => lengthBeforeCaliber2 = value; }
        public double LengthFromCaliber2BeforeWell { get => lengthFromCaliber2BeforeWell; set => lengthFromCaliber2BeforeWell = value; }
        public double DiameterWell { get => diameterWell; set => diameterWell = value; }
        public double DiametreNozzleHole { get => diametreNozzleHole; set => diametreNozzleHole = value; }
        public double AngleAlpha1 { get => angleAlpha1; set => angleAlpha1 = value; }
        public double AngleAlpha2 { get => angleAlpha2; set => angleAlpha2 = value; }
        public double AngleAlpha3 { get => angleAlpha3; set => angleAlpha3 = value; }
        public double AngleAlpha4 { get => angleAlpha4; set => angleAlpha4 = value; }
        public double AngleAlpha5 { get => angleAlpha5; set => angleAlpha5 = value; }
        public double AngleAlpha6 { get => angleAlpha6; set => angleAlpha6 = value; }
        public double AngleAlpha7 { get => angleAlpha7; set => angleAlpha7 = value; }
        public double AngleAlpha8 { get => angleAlpha8; set => angleAlpha8 = value; }
        public double AngleAlpha9 { get => angleAlpha9; set => angleAlpha9 = value; }
        public double AngleAlpha10 { get => angleAlpha10; set => angleAlpha10 = value; }
        public double AnglePhi1 { get => anglePhi1; set => anglePhi1 = value; }
        public double AnglePhi2 { get => anglePhi2; set => anglePhi2 = value; }
        public double AnglePhi3 { get => anglePhi3; set => anglePhi3 = value; }
        public double AnglePhi4 { get => anglePhi4; set => anglePhi4 = value; }
        public double AnglePhi5 { get => anglePhi5; set => anglePhi5 = value; }
        public double AnglePhi6 { get => anglePhi6; set => anglePhi6 = value; }
        public double AnglePhi7 { get => anglePhi7; set => anglePhi7 = value; }
        public double AnglePhi8 { get => anglePhi8; set => anglePhi8 = value; }
        public double AnglePhi9 { get => anglePhi9; set => anglePhi9 = value; }
        public double AnglePhi10 { get => anglePhi10; set => anglePhi10 = value; }
        public double KiFromCaliber2_11 { get => KiFromCaliber2_1; set => KiFromCaliber2_1 = value; }
        public double KiFromCaliber2_21 { get => KiFromCaliber2_2; set => KiFromCaliber2_2 = value; }
        public double KiFromCaliber2_31 { get => KiFromCaliber2_3; set => KiFromCaliber2_3 = value; }
        public double KiFromCaliber2_41 { get => KiFromCaliber2_4; set => KiFromCaliber2_4 = value; }
        public double KiFromCaliber2_51 { get => KiFromCaliber2_5; set => KiFromCaliber2_5 = value; }
        public double KiFromCaliber2_61 { get => KiFromCaliber2_6; set => KiFromCaliber2_6 = value; }
        public double KiFromCaliber2_71 { get => KiFromCaliber2_7; set => KiFromCaliber2_7 = value; }
        public double KiFromCaliber2_81 { get => KiFromCaliber2_8; set => KiFromCaliber2_8 = value; }
        public double KiFromCaliber2_91 { get => KiFromCaliber2_9; set => KiFromCaliber2_9 = value; }
        public double KiFromCaliber2_101 { get => KiFromCaliber2_10; set => KiFromCaliber2_10 = value; }
        public double PercentHydropolishing { get => percentHydropolishing; set => percentHydropolishing = value; }
        public double PercentThrottling { get => percentThrottling; set => percentThrottling = value; }
        public double HydrodensityDown { get => hydrodensityDown; set => hydrodensityDown = value; }
        public double HydrodensityUp { get => hydrodensityUp; set => hydrodensityUp = value; }
        public double DrowningNeedle { get => drowningNeedle; set => drowningNeedle = value; }
        public double DrowningNeedleLimitDown { get => drowningNeedleLimitDown; set => drowningNeedleLimitDown = value; }
        public double DrowningNeedleLimitUp { get => drowningNeedleLimitUp; set => drowningNeedleLimitUp = value; }
        public double ProtrusionShank { get => protrusionShank; set => protrusionShank = value; }
        public double ProtrusionShankLimitDown { get => protrusionShankLimitDown; set => protrusionShankLimitDown = value; }
        public double ProtrusionShankLimitUp { get => protrusionShankLimitUp; set => protrusionShankLimitUp = value; }
        public double RateSonplasMinInTheCollection { get => rateSonplasMinInTheCollection; set => rateSonplasMinInTheCollection = value; }
        public double RateSonplasMaxInTheCollection { get => rateSonplasMaxInTheCollection; set => rateSonplasMaxInTheCollection = value; }
        public double RateMfMinInTheCollection { get => rateMfMinInTheCollection; set => rateMfMinInTheCollection = value; }
        public double RateMfMaxInTheCollection { get => rateMfMaxInTheCollection; set => rateMfMaxInTheCollection = value; }
        
    }

    public class Injector9notMandrel : IInjector
    {
        public Injector9notMandrel(InjectorSize injector, Detail det, Allowances allowan)
        {
            InjectorSize injectorSize = injector;
            Detail detail = det;
            Allowances allowances = allowan;
        }

        public double[] AggregateDrillingMicron(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] AggregateDrillingUnis(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public object[] Assembly(string needle, params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double Blank(double length_detail)
        {
            throw new NotImplementedException();
        }

        public double[] Broach(params double[] size_broach)
        {
            throw new NotImplementedException();
        }

        public double[] ControlOperationFinal(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] ControlOperationHardy(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] ControlOperationRaw(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] ElectrochemicalPocket(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] GrindingChamferFinal()
        {
            throw new NotImplementedException();
        }

        public double[] GrindingChamferPreliminary()
        {
            throw new NotImplementedException();
        }

        public double GrindingCup()
        {
            throw new NotImplementedException();
        }

        public double[] GrindingCupFinal()
        {
            throw new NotImplementedException();
        }

        public double[] GrindingProfile(int size7or9)
        {
            throw new NotImplementedException();
        }

        public double[] GrindingSphere(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public double[] GrindingUVA(params double[] sizes)
        {
            throw new NotImplementedException();
        }

        public string[] Marking(params string[] data_marking)
        {
            throw new NotImplementedException();
        }

        public double[] Polishing(params double[] consuption)
        {
            throw new NotImplementedException();
        }

        public double[] TurningBearingButt()
        {
            throw new NotImplementedException();
        }

        public double[] TurningRIKA(params double[] sizes)
        {
            throw new NotImplementedException();
        }
    }
}
