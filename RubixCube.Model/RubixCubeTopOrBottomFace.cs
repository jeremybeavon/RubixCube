using System.ComponentModel.DataAnnotations;

namespace RubixCube.Model
{
    public abstract class RubixCubeTopOrBottomFace
    {
        private readonly string description;

        protected RubixCubeTopOrBottomFace(string description)
        {
            this.description = description;
        }

        [Required]
        public CubeWith3Faces BackLeftCube { get; internal set; }

        [Required]
        public CubeWith2Faces BackCube { get; internal set; }

        [Required]
        public CubeWith3Faces BackRightCube { get; internal set; }
        
        [Required]
        public CubeWith2Faces LeftCube { get; internal set; }

        [Required]
        public CubeWith1Face CenterCube { get; internal set; }

        [Required]
        public CubeWith2Faces RightCube { get; internal set; }

        [Required]
        public CubeWith3Faces FrontLeftCube { get; internal set; }

        [Required]
        public CubeWith2Faces FrontCube { get; internal set; }

        [Required]
        public CubeWith3Faces FrontRightCube { get; internal set; }

        internal NamedCube<CubeWith3Faces> NamedBackLeftCube
        {
            get { return new NamedCube<CubeWith3Faces>(BackLeftCube, description + "BackLeftCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedBackCube
        {
            get { return new NamedCube<CubeWith2Faces>(BackCube, description + "BackCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedBackRightCube
        {
            get { return new NamedCube<CubeWith3Faces>(BackRightCube, description + "BackRightCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedLeftCube
        {
            get { return new NamedCube<CubeWith2Faces>(LeftCube, description + "LeftCube"); }
        }

        internal NamedCube<CubeWith1Face> NamedCenterCube
        {
            get { return new NamedCube<CubeWith1Face>(CenterCube, description + "CenterCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedRightCube
        {
            get { return new NamedCube<CubeWith2Faces>(RightCube, description + "RightCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedFrontLeftCube
        {
            get { return new NamedCube<CubeWith3Faces>(FrontLeftCube, description + "FrontLeftCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedFrontCube
        {
            get { return new NamedCube<CubeWith2Faces>(FrontCube, description + "FrontCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedFrontRightCube
        {
            get { return new NamedCube<CubeWith3Faces>(FrontRightCube, description + "FrontRightCube"); }
        }

        internal void Validate(RubixCubeFaceValidationResult validation)
        {
            Validator.ValidateObject(this, new ValidationContext(this), true);
            validation.Description = description;
            validation.ValidateAdjacentCubes(NamedBackLeftCube, NamedBackCube);
            validation.ValidateAdjacentCubes(NamedBackLeftCube, NamedLeftCube);
            validation.ValidateAdjacentCubes(NamedBackCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBackRightCube, NamedBackCube);
            validation.ValidateAdjacentCubes(NamedBackRightCube, NamedRightCube);
            validation.ValidateAdjacentCubes(NamedLeftCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedRightCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedFrontLeftCube, NamedFrontCube);
            validation.ValidateAdjacentCubes(NamedFrontLeftCube, NamedLeftCube);
            validation.ValidateAdjacentCubes(NamedFrontCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedFrontRightCube, NamedFrontCube);
            validation.ValidateAdjacentCubes(NamedFrontRightCube, NamedRightCube);
        }

        protected void Clone(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = BackLeftCube;
            newFace.BackCube = BackCube;
            newFace.BackRightCube = BackRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.FrontLeftCube = FrontLeftCube;
            newFace.FrontCube = FrontCube;
            newFace.FrontRightCube = FrontRightCube;
        }

        protected void RotateClockwiseThroughCenterCube(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = FrontLeftCube;
            newFace.BackCube = LeftCube;
            newFace.BackRightCube = BackLeftCube;
            newFace.LeftCube = FrontCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = BackCube;
            newFace.FrontLeftCube = FrontRightCube;
            newFace.FrontCube = RightCube;
            newFace.FrontRightCube = BackRightCube;
        }

        protected void RotateAntiClockwiseThroughCenterCube(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = BackRightCube;
            newFace.BackCube = RightCube;
            newFace.BackRightCube = FrontRightCube;
            newFace.LeftCube = BackCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = FrontCube;
            newFace.FrontLeftCube = BackLeftCube;
            newFace.FrontCube = LeftCube;
            newFace.FrontRightCube = FrontLeftCube;
        }

        protected void RotateClockwiseThroughFront(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = FrontLeftCube;
            newFace.TopCube = LeftCube;
            newFace.BackTopCube = BackLeftCube;
            newFace.FrontCube = FrontCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = BackCube;
            newFace.FrontBottomCube = FrontRightCube;
            newFace.BottomCube = RightCube;
            newFace.BackBottomCube = BackRightCube;
        }

        protected void RotateAnticlockwiseThroughFront(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = FrontRightCube;
            newFace.TopCube = RightCube;
            newFace.BackTopCube = BackRightCube;
            newFace.FrontCube = FrontCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = BackCube;
            newFace.FrontBottomCube = FrontLeftCube;
            newFace.BottomCube = LeftCube;
            newFace.BackBottomCube = BackLeftCube;
        }

        protected void RotateClockwiseThroughLeft(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = FrontLeftCube;
            newFace.TopCube = FrontCube;
            newFace.TopRightCube = FrontRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.BottomLeftCube = BackLeftCube;
            newFace.BottomCube = BackCube;
            newFace.BottomRightCube = BackRightCube;
        }

        protected void RotateAnticlockwiseThroughLeft(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = BackLeftCube;
            newFace.TopCube = BackCube;
            newFace.TopRightCube = BackRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.BottomLeftCube = FrontLeftCube;
            newFace.BottomCube = FrontCube;
            newFace.BottomRightCube = FrontRightCube;
        }
    }
}
