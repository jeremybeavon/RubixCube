using System.ComponentModel.DataAnnotations;

namespace RubixCube.Model
{
    public abstract class RubixCubeLeftOrRightFace
    {
        private readonly string description;

        protected RubixCubeLeftOrRightFace(string description)
        {
            this.description = description;
        }

        public CubeWith3Faces FrontTopCube { get; internal set; }

        public CubeWith2Faces TopCube { get; internal set; }

        public CubeWith3Faces BackTopCube { get; internal set; }

        public CubeWith2Faces FrontCube { get; internal set; }

        public CubeWith1Face CenterCube { get; internal set; }

        public CubeWith2Faces BackCube { get; internal set; }

        public CubeWith3Faces FrontBottomCube { get; internal set; }

        public CubeWith2Faces BottomCube { get; internal set; }

        public CubeWith3Faces BackBottomCube { get; internal set; }

        internal NamedCube<CubeWith3Faces> NamedFrontTopCube
        {
            get { return new NamedCube<CubeWith3Faces>(FrontTopCube, description + "FrontTopCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedTopCube
        {
            get { return new NamedCube<CubeWith2Faces>(TopCube, description + "TopCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedBackTopCube
        {
            get { return new NamedCube<CubeWith3Faces>(BackTopCube, description + "BackTopCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedFrontCube
        {
            get { return new NamedCube<CubeWith2Faces>(FrontCube, description + "FrontCube"); }
        }

        internal NamedCube<CubeWith1Face> NamedCenterCube
        {
            get { return new NamedCube<CubeWith1Face>(CenterCube, description + "CenterCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedBackCube
        {
            get { return new NamedCube<CubeWith2Faces>(BackCube, description + "BackCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedFrontBottomCube
        {
            get { return new NamedCube<CubeWith3Faces>(FrontBottomCube, description + "FrontBottomCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedBottomCube
        {
            get { return new NamedCube<CubeWith2Faces>(BottomCube, description + "BottomCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedBackBottomCube
        {
            get { return new NamedCube<CubeWith3Faces>(BackBottomCube, description + "BackBottomCube"); }
        }

        internal void Validate(RubixCubeFaceValidationResult validation)
        {
            Validator.ValidateObject(this, new ValidationContext(this), true);
            validation.Description = description;
            validation.ValidateAdjacentCubes(NamedFrontTopCube, NamedTopCube);
            validation.ValidateAdjacentCubes(NamedFrontTopCube, NamedFrontCube);
            validation.ValidateAdjacentCubes(NamedTopCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBackTopCube, NamedTopCube);
            validation.ValidateAdjacentCubes(NamedBackTopCube, NamedBackCube);
            validation.ValidateAdjacentCubes(NamedFrontCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBackCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBackTopCube, NamedTopCube);
            validation.ValidateAdjacentCubes(NamedBackTopCube, NamedBackCube);
            validation.ValidateAdjacentCubes(NamedBottomCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBackBottomCube, NamedBottomCube);
            validation.ValidateAdjacentCubes(NamedBackBottomCube, NamedBackCube);
        }

        protected void Clone(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = FrontTopCube;
            newFace.TopCube = TopCube;
            newFace.BackTopCube = BackTopCube;
            newFace.FrontCube = FrontCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = BackCube;
            newFace.FrontBottomCube = FrontBottomCube;
            newFace.BottomCube = BottomCube;
            newFace.BackBottomCube = BackBottomCube;
        }

        protected void RotateClockwiseThroughCenterCube(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = FrontBottomCube;
            newFace.TopCube = FrontCube;
            newFace.BackTopCube = FrontTopCube;
            newFace.FrontCube = BottomCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = TopCube;
            newFace.FrontBottomCube = BackBottomCube;
            newFace.BottomCube = BackCube;
            newFace.BackBottomCube = BackTopCube;
        }

        protected void RotateAntiClockwiseThroughCenterCube(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = BackTopCube;
            newFace.TopCube = BackCube;
            newFace.BackTopCube = BackBottomCube;
            newFace.FrontCube = TopCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = BottomCube;
            newFace.FrontBottomCube = FrontTopCube;
            newFace.BottomCube = FrontCube;
            newFace.BackBottomCube = FrontBottomCube;
        }

        protected void RotateClockwiseThroughTop(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = FrontTopCube;
            newFace.TopCube = TopCube;
            newFace.TopRightCube = BackTopCube;
            newFace.LeftCube = FrontCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = BackCube;
            newFace.BottomLeftCube = FrontBottomCube;
            newFace.BottomCube = BottomCube;
            newFace.BottomRightCube = BackBottomCube;
        }

        protected void RotateAnticlockwiseThroughTop(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = BackTopCube;
            newFace.TopCube = TopCube;
            newFace.TopRightCube = FrontTopCube;
            newFace.LeftCube = BackCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = FrontCube;
            newFace.BottomLeftCube = BackBottomCube;
            newFace.BottomCube = BottomCube;
            newFace.BottomRightCube = FrontBottomCube;
        }

        protected void RotateClockwiseThroughFront(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = BackBottomCube;
            newFace.BackCube = BackCube;
            newFace.BackRightCube = BackTopCube;
            newFace.LeftCube = BottomCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = TopCube;
            newFace.FrontLeftCube = FrontBottomCube;
            newFace.FrontCube = FrontCube;
            newFace.FrontRightCube = FrontTopCube;
        }

        protected void RotateAnticlockwiseThroughFront(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = BackTopCube;
            newFace.BackCube = BackCube;
            newFace.BackRightCube = BackBottomCube;
            newFace.LeftCube = TopCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = BottomCube;
            newFace.FrontLeftCube = FrontTopCube;
            newFace.FrontCube = FrontCube;
            newFace.FrontRightCube = FrontBottomCube;
        }
    }
}
