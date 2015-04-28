using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RubixCube.Model
{
    public abstract class RubixCubeFrontOrBackFace
    {
        private readonly string description;

        protected RubixCubeFrontOrBackFace(string description)
        {
            this.description = description;
        }

        [Required]
        public CubeWith3Faces TopLeftCube { get; internal set; }

        [Required]
        public CubeWith2Faces TopCube { get; internal set; }

        [Required]
        public CubeWith3Faces TopRightCube { get; internal set; }

        [Required]
        public CubeWith2Faces LeftCube { get; internal set; }

        [Required]
        public CubeWith1Face CenterCube { get; internal set; }

        [Required]
        public CubeWith2Faces RightCube { get; internal set; }

        [Required]
        public CubeWith3Faces BottomLeftCube { get; internal set; }

        [Required]
        public CubeWith2Faces BottomCube { get; internal set; }

        [Required]
        public CubeWith3Faces BottomRightCube { get; internal set; }

        internal NamedCube<CubeWith3Faces> NamedTopLeftCube
        {
            get { return new NamedCube<CubeWith3Faces>(TopLeftCube, description + "TopLeftCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedTopCube
        {
            get { return new NamedCube<CubeWith2Faces>(TopCube, description + "TopCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedTopRightCube
        {
            get { return new NamedCube<CubeWith3Faces>(TopRightCube, description + "TopRightCube"); }
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

        internal NamedCube<CubeWith3Faces> NamedBottomLeftCube
        {
            get { return new NamedCube<CubeWith3Faces>(BottomLeftCube, description + "BottomLeftCube"); }
        }

        internal NamedCube<CubeWith2Faces> NamedBottomCube
        {
            get { return new NamedCube<CubeWith2Faces>(BottomCube, description + "BottomCube"); }
        }

        internal NamedCube<CubeWith3Faces> NamedBottomRightCube
        {
            get { return new NamedCube<CubeWith3Faces>(BottomRightCube, description + "BottomRightCube"); }
        }

        internal void Validate(RubixCubeFaceValidationResult validation)
        {
            Validator.ValidateObject(this, new ValidationContext(this), true);
            validation.ValidateAdjacentCubes(NamedTopLeftCube, NamedTopCube);
            validation.ValidateAdjacentCubes(NamedTopLeftCube, NamedLeftCube);
            validation.ValidateAdjacentCubes(NamedTopCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedTopRightCube, NamedTopCube);
            validation.ValidateAdjacentCubes(NamedTopRightCube, NamedRightCube);
            validation.ValidateAdjacentCubes(NamedLeftCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedRightCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBottomLeftCube, NamedBottomCube);
            validation.ValidateAdjacentCubes(NamedBottomLeftCube, NamedLeftCube);
            validation.ValidateAdjacentCubes(NamedBottomCube, NamedCenterCube);
            validation.ValidateAdjacentCubes(NamedBottomRightCube, NamedBottomCube);
            validation.ValidateAdjacentCubes(NamedBottomRightCube, NamedRightCube);
        }

        protected void Clone(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = TopLeftCube;
            newFace.TopCube = TopCube;
            newFace.TopRightCube = TopRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.BottomLeftCube = BottomLeftCube;
            newFace.BottomCube = BottomCube;
            newFace.BottomRightCube = BottomRightCube;
        }

        protected void RotateClockwiseThroughCenterCube(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = BottomLeftCube;
            newFace.TopCube = LeftCube;
            newFace.TopRightCube = TopLeftCube;
            newFace.LeftCube = BottomCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = TopCube;
            newFace.BottomLeftCube = BottomRightCube;
            newFace.BottomCube = RightCube;
            newFace.BottomRightCube = TopRightCube;
        }

        protected void RotateAntiClockwiseThroughCenterCube(RubixCubeFrontOrBackFace newFace)
        {
            newFace.TopLeftCube = TopRightCube;
            newFace.TopCube = RightCube;
            newFace.TopRightCube = BottomRightCube;
            newFace.LeftCube = TopCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = BottomCube;
            newFace.BottomLeftCube = TopLeftCube;
            newFace.BottomCube = LeftCube;
            newFace.BottomRightCube = BottomLeftCube;
        }

        protected void RotateClockwiseThroughTop(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = TopRightCube;
            newFace.TopCube = TopCube;
            newFace.BackTopCube = TopLeftCube;
            newFace.FrontCube = RightCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = LeftCube;
            newFace.FrontBottomCube = BottomRightCube;
            newFace.BottomCube = BottomCube;
            newFace.BackBottomCube = BottomLeftCube;
        }

        protected void RotateAnticlockwiseThroughTop(RubixCubeLeftOrRightFace newFace)
        {
            newFace.FrontTopCube = TopLeftCube;
            newFace.TopCube = TopCube;
            newFace.BackTopCube = TopRightCube;
            newFace.FrontCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.BackCube = RightCube;
            newFace.FrontBottomCube = BottomLeftCube;
            newFace.BottomCube = BottomCube;
            newFace.BackBottomCube = BottomRightCube;
        }

        protected void RotateClockwiseThroughLeft(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = BottomLeftCube;
            newFace.BackCube = BottomCube;
            newFace.BackRightCube = BottomRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.FrontLeftCube = TopLeftCube;
            newFace.FrontCube = TopCube;
            newFace.FrontRightCube = TopRightCube;
        }

        protected void RotateAnticlockwiseThroughLeft(RubixCubeTopOrBottomFace newFace)
        {
            newFace.BackLeftCube = TopLeftCube;
            newFace.BackCube = TopCube;
            newFace.BackRightCube = TopRightCube;
            newFace.LeftCube = LeftCube;
            newFace.CenterCube = CenterCube;
            newFace.RightCube = RightCube;
            newFace.FrontLeftCube = BottomLeftCube;
            newFace.FrontCube = BottomCube;
            newFace.FrontRightCube = BottomRightCube;
        }
    }
}
