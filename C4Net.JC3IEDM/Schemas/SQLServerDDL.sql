USE [Test]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [JC3IEDM].[ABS_POINT] (
    [abs_point_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [abs_point_ver_dist_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AbsPoint] PRIMARY KEY NONCLUSTERED 
  (
  [abs_point_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Act] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_ACFT_EMPLOY] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [act_res_employ_ix] [NUMERIC](20,0) NOT NULL,
    [appr_offset_code] [NVARCHAR](6),
    [deplane_method_code] [NVARCHAR](6),
    [egress_dir_angle] [NUMERIC](7,4),
    [iflrp_reqmnt_ind_code] [NVARCHAR](6),
    [ingress_dir_angle] [NUMERIC](7,4),
    [crew_cmps_code] [NVARCHAR](6),
    [gen_role_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActAcftEmploy] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC,
  [act_res_employ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_CONTXT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [act_contxt_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActContxt] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [contxt_id] ASC,
  [act_contxt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EFFECT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_effect_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [descr_code] [NVARCHAR](6) NOT NULL,
    [sev_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEffect] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_effect_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_FUNCTL_ASSOC] (
    [subj_act_id] [NUMERIC](20,0) NOT NULL,
    [obj_act_id] [NUMERIC](20,0) NOT NULL,
    [act_functl_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActFunctlAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_act_id] ASC,
  [obj_act_id] ASC,
  [act_functl_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [qual_code] [NVARCHAR](6),
    [authorising_org_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjve] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE_ITEM] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [primacy_code] [NVARCHAR](6),
    [ctgtlst_id] [NUMERIC](20,0),
    [ctgtdet_item_ix] [NUMERIC](20,0),
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjveItem] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE_TYPE] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [prio_txt] [NVARCHAR](20),
    [qty] [NUMERIC](12,3),
    [ctgtlst_id] [NUMERIC](20,0),
    [ctgtdet_type_ix] [NUMERIC](20,0),
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjveType] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_REQ_CAPAB] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [capab_id] [NUMERIC](20,0) NOT NULL,
    [qty] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActReqCapab] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_RES] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [criticality_ind_code] [NVARCHAR](6),
    [qual_code] [NVARCHAR](6),
    [authorising_org_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActRes] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_RES_EMPLOY] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [act_res_employ_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [azimuth_fire_angle] [NUMERIC](7,4),
    [method_of_ctrl_code] [NVARCHAR](6),
    [trajectory_fire_code] [NVARCHAR](6),
    [act_objve_ix] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActResEmploy] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC,
  [act_res_employ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_RES_ITEM] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActResItem] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_RES_TYPE] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [qty] [NUMERIC](9,0),
    [aprtnmt_rat] [NUMERIC](6,5),
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActResType] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_TMPRL_ASSOC] (
    [subj_act_id] [NUMERIC](20,0) NOT NULL,
    [obj_act_id] [NUMERIC](20,0) NOT NULL,
    [act_tmprl_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [ref_dur] [NUMERIC](19,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActTmprlAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_act_id] ASC,
  [obj_act_id] ASC,
  [act_tmprl_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ATMOSPHERE] (
    [atmosphere_id] [NUMERIC](20,0) NOT NULL,
    [humidity_rat] [NUMERIC](6,5),
    [inversion_layer_code] [NVARCHAR](6),
    [prs_qty] [NUMERIC](8,4),
    [prs_sys_cat_code] [NVARCHAR](6),
    [tmpr] [NUMERIC](5,1),
    [tmpr_gradient_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Atmosphere] PRIMARY KEY NONCLUSTERED 
  (
  [atmosphere_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BRIDGE] (
    [bridge_id] [NUMERIC](20,0) NOT NULL,
    [longest_span_length_dim] [NUMERIC](12,3),
    [span_cnt] [NUMERIC](3,0),
    [usage_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Bridge] PRIMARY KEY NONCLUSTERED 
  (
  [bridge_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CAPAB] (
    [capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [day_night_code] [NVARCHAR](6),
    [uom_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Capab] PRIMARY KEY NONCLUSTERED 
  (
  [capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CLOUD_COVER] (
    [cloud_cover_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [base_dim] [NUMERIC](12,3),
    [top_dim] [NUMERIC](12,3),
    [avg_cvrg_code] [NVARCHAR](6),
    [light_refraction_rat] [NUMERIC](7,6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CloudCover] PRIMARY KEY NONCLUSTERED 
  (
  [cloud_cover_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONE_VOL] (
    [cone_vol_id] [NUMERIC](20,0) NOT NULL,
    [cone_vol_dfng_surf_id] [NUMERIC](20,0) NOT NULL,
    [vertex_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ConeVol] PRIMARY KEY NONCLUSTERED 
  (
  [cone_vol_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONS_MAT_TYPE] (
    [cons_mat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [hazard_code] [NVARCHAR](6),
    [issuing_elmt_code] [NVARCHAR](6),
    [issuing_cnt] [NUMERIC](9,0),
    [issuing_uom_code] [NVARCHAR](6),
    [issuing_wt_qty] [NUMERIC](12,3),
    [perishability_ind_code] [NVARCHAR](6),
    [united_nations_no_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ConsMatType] PRIMARY KEY NONCLUSTERED 
  (
  [cons_mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](80),
    [security_clsfc_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Contxt] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_ASSESS] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [contxt_assess_ix] [NUMERIC](20,0) NOT NULL,
    [txt] [NVARCHAR](4000) NOT NULL,
    [limiting_factors_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtAssess] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [contxt_assess_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTRL_FEAT] (
    [ctrl_feat_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtrlFeat] PRIMARY KEY NONCLUSTERED 
  (
  [ctrl_feat_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTRL_FEAT_TYPE] (
    [ctrl_feat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [echln_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtrlFeatType] PRIMARY KEY NONCLUSTERED 
  (
  [ctrl_feat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONVOY] (
    [convoy_id] [NUMERIC](20,0) NOT NULL,
    [day_speed_rate] [NUMERIC](8,4),
    [day_vehicle_gap_dim] [NUMERIC](12,3),
    [halt_dur] [NUMERIC](19,0),
    [night_speed_rate] [NUMERIC](8,4),
    [night_vehicle_gap_dim] [NUMERIC](12,3),
    [packet_gap_dim] [NUMERIC](12,3),
    [packet_size_cnt] [NUMERIC](9,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Convoy] PRIMARY KEY NONCLUSTERED 
  (
  [convoy_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ENG_CAPAB] (
    [eng_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [fac_height_dim] [NUMERIC](12,3) NOT NULL,
    [fac_length_dim] [NUMERIC](12,3) NOT NULL,
    [fac_width_dim] [NUMERIC](12,3) NOT NULL,
    [fac_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_EngCapab] PRIMARY KEY NONCLUSTERED 
  (
  [eng_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[EQPT_TYPE] (
    [eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [loaded_wt_qty] [NUMERIC](12,3),
    [unloaded_wt_qty] [NUMERIC](12,3),
    [max_height_dim] [NUMERIC](12,3),
    [max_length_dim] [NUMERIC](12,3),
    [max_width_dim] [NUMERIC](12,3),
    [fuel_cap_qty] [NUMERIC](9,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_EqptType] PRIMARY KEY NONCLUSTERED 
  (
  [eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FAC] (
    [fac_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [prim_const_matrl_code] [NVARCHAR](6),
    [base_identific_code_txt] [NVARCHAR](15),
    [height_dim] [NUMERIC](12,3),
    [length_dim] [NUMERIC](12,3),
    [width_dim] [NUMERIC](12,3),
    [fac_major_building_type_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Fac] PRIMARY KEY NONCLUSTERED 
  (
  [fac_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FAC_TYPE] (
    [fac_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_FacType] PRIMARY KEY NONCLUSTERED 
  (
  [fac_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FAN_AREA] (
    [fan_area_id] [NUMERIC](20,0) NOT NULL,
    [mnm_range_dim] [NUMERIC](12,3) NOT NULL,
    [max_range_dim] [NUMERIC](12,3),
    [orient_angle] [NUMERIC](7,4) NOT NULL,
    [sctr_size_angle] [NUMERIC](7,4) NOT NULL,
    [fan_area_vertex_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_FanArea] PRIMARY KEY NONCLUSTERED 
  (
  [fan_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FEAT] (
    [feat_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Feat] PRIMARY KEY NONCLUSTERED 
  (
  [feat_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FEAT_TYPE] (
    [feat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_FeatType] PRIMARY KEY NONCLUSTERED 
  (
  [feat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FIRE_CAPAB] (
    [fire_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [weapon_type_code] [NVARCHAR](6),
    [ammo_type_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_FireCapab] PRIMARY KEY NONCLUSTERED 
  (
  [fire_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GEO_FEAT] (
    [geo_feat_id] [NUMERIC](20,0) NOT NULL,
    [btm_hardness_code] [NVARCHAR](6),
    [btm_penetration_qty] [NUMERIC](3,2),
    [sld_surf_cmps_code] [NVARCHAR](6),
    [surf_cat_code] [NVARCHAR](6),
    [trn_code] [NVARCHAR](6),
    [veg_cat_code] [NVARCHAR](6),
    [veg_subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GeoFeat] PRIMARY KEY NONCLUSTERED 
  (
  [geo_feat_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GEO_FEAT_TYPE] (
    [geo_feat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GeoFeatType] PRIMARY KEY NONCLUSTERED 
  (
  [geo_feat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GEOM_VOL] (
    [geom_vol_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [geom_vol_lower_ver_dist_id] [NUMERIC](20,0),
    [geom_vol_upper_ver_dist_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GeomVol] PRIMARY KEY NONCLUSTERED 
  (
  [geom_vol_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[HOLDING] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [holding_ix] [NUMERIC](20,0) NOT NULL,
    [operat_cnt] [NUMERIC](9,0),
    [total_qty] [NUMERIC](9,0),
    [on_hand_qty] [NUMERIC](9,0),
    [req_total_qty] [NUMERIC](9,0),
    [req_on_hand_qty] [NUMERIC](9,0),
    [req_mthd_calc_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Holding] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_type_id] ASC,
  [holding_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LIGHT] (
    [light_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [up_dttm] [CHAR](18),
    [down_dttm] [CHAR](18),
    [moon_phase_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Light] PRIMARY KEY NONCLUSTERED 
  (
  [light_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LINE] (
    [line_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Line] PRIMARY KEY NONCLUSTERED 
  (
  [line_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LINE_POINT] (
    [line_id] [NUMERIC](20,0) NOT NULL,
    [line_point_ix] [NUMERIC](20,0) NOT NULL,
    [seq_ord] [NUMERIC](6,0) NOT NULL,
    [point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_LinePoint] PRIMARY KEY NONCLUSTERED 
  (
  [line_id] ASC,
  [line_point_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LOC] (
    [loc_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Loc] PRIMARY KEY NONCLUSTERED 
  (
  [loc_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MAT] (
    [mat_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [serial_no_id_txt] [NVARCHAR](50),
    [lot_identific_txt] [NVARCHAR](100),
    [hull_no_txt] [NVARCHAR](15),
    [mine_rqn_case_no_txt] [NVARCHAR](15),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Mat] PRIMARY KEY NONCLUSTERED 
  (
  [mat_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MAT_TYPE] (
    [mat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rptbl_item_txt] [NVARCHAR](6),
    [stock_no_txt] [NVARCHAR](15),
    [supply_class_code] [NVARCHAR](6),
    [issuing_height_dim] [NUMERIC](12,3),
    [issuing_length_dim] [NUMERIC](12,3),
    [issuing_width_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MatType] PRIMARY KEY NONCLUSTERED 
  (
  [mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MET_FEAT] (
    [met_feat_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [interpretation_code] [NVARCHAR](6) NOT NULL,
    [prob_rat] [NUMERIC](6,5),
    [source_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MetFeat] PRIMARY KEY NONCLUSTERED 
  (
  [met_feat_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD] (
    [mnfld_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [identific_txt] [NVARCHAR](15),
    [mine_spc_dim] [NUMERIC](12,3),
    [destruction_dttm] [CHAR](18),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Mnfld] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](100) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItem] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_CAPAB] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [capab_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_capab_ix] [NUMERIC](20,0) NOT NULL,
    [msn_primacy_code] [NVARCHAR](6),
    [qty] [NUMERIC](12,3),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemCapab] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [capab_id] ASC,
  [obj_item_capab_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_STAT] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [booby_trap_prsnc_code] [NVARCHAR](6),
    [emsn_ctrl_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemStat] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_TYPE] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_type_ix] [NUMERIC](20,0) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemType] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_type_id] ASC,
  [obj_item_type_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE] (
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [decoy_ind_code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](100) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjType] PRIMARY KEY NONCLUSTERED 
  (
  [obj_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE_CAPAB_NORM] (
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [capab_id] [NUMERIC](20,0) NOT NULL,
    [msn_primacy_code] [NVARCHAR](6),
    [qty] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjTypeCapabNorm] PRIMARY KEY NONCLUSTERED 
  (
  [obj_type_id] ASC,
  [capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Org] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_TYPE] (
    [org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [cmd_func_ind_code] [NVARCHAR](6) NOT NULL,
    [cmd_and_ctrl_cat_code] [NVARCHAR](6),
    [descr_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgType] PRIMARY KEY NONCLUSTERED 
  (
  [org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PERS] (
    [pers_id] [NUMERIC](20,0) NOT NULL,
    [birth_dttm] [CHAR](18),
    [blood_type_code] [NVARCHAR](6),
    [gender_code] [NVARCHAR](6),
    [professing_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Pers] PRIMARY KEY NONCLUSTERED 
  (
  [pers_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PERS_STAT] (
    [pers_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [duty_stat_code] [NVARCHAR](6),
    [physcl_stat_code] [NVARCHAR](6),
    [physcl_stat_qual_code] [NVARCHAR](6),
    [rad_dose_qty] [NUMERIC](6,0),
    [reserve_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PersStat] PRIMARY KEY NONCLUSTERED 
  (
  [pers_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PERS_TYPE] (
    [pers_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [rank_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PersType] PRIMARY KEY NONCLUSTERED 
  (
  [pers_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POINT] (
    [point_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Point] PRIMARY KEY NONCLUSTERED 
  (
  [point_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PRECIPITATION] (
    [precipitation_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rate] [NUMERIC](4,1),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Precipitation] PRIMARY KEY NONCLUSTERED 
  (
  [precipitation_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REL_POINT] (
    [rel_point_id] [NUMERIC](20,0) NOT NULL,
    [x_coord_dim] [NUMERIC](12,3) NOT NULL,
    [y_coord_dim] [NUMERIC](12,3) NOT NULL,
    [z_coord_dim] [NUMERIC](12,3),
    [x_precision_code] [NVARCHAR](6),
    [y_precision_code] [NVARCHAR](6),
    [z_precision_code] [NVARCHAR](6),
    [rel_coord_sys_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RelPoint] PRIMARY KEY NONCLUSTERED 
  (
  [rel_point_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REQUEST] (
    [request_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [immd_interest_ind_code] [NVARCHAR](6),
    [latest_ans_dttm] [CHAR](18),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Request] PRIMARY KEY NONCLUSTERED 
  (
  [request_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REQUEST_ANS] (
    [request_id] [NUMERIC](20,0) NOT NULL,
    [request_ans_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RequestAns] PRIMARY KEY NONCLUSTERED 
  (
  [request_id] ASC,
  [request_ans_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REQUEST_ANS_ELMT] (
    [request_id] [NUMERIC](20,0) NOT NULL,
    [request_ans_ix] [NUMERIC](20,0) NOT NULL,
    [comprising_rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RequestAnsElmt] PRIMARY KEY NONCLUSTERED 
  (
  [request_id] ASC,
  [request_ans_ix] ASC,
  [comprising_rptd_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ROUTE] (
    [route_id] [NUMERIC](20,0) NOT NULL,
    [dir_usage_code] [NVARCHAR](6),
    [mob_code] [NVARCHAR](6),
    [mode_of_trnsp_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Route] PRIMARY KEY NONCLUSTERED 
  (
  [route_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ROE] (
    [roe_id] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [descr_txt] [NVARCHAR](255) NOT NULL,
    [owning_org_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Roe] PRIMARY KEY NONCLUSTERED 
  (
  [roe_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[STORAGE_CAPAB] (
    [storage_capab_id] [NUMERIC](20,0) NOT NULL,
    [cargo_cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [cond_code] [NVARCHAR](6),
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_StorageCapab] PRIMARY KEY NONCLUSTERED 
  (
  [storage_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SURF] (
    [surf_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Surf] PRIMARY KEY NONCLUSTERED 
  (
  [surf_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SURV_CAPAB] (
    [surv_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SurvCapab] PRIMARY KEY NONCLUSTERED 
  (
  [surv_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[TARGET] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [engage_authy_code] [NVARCHAR](6),
    [id_txt] [NVARCHAR](15),
    [persistence_dur] [NUMERIC](19,0),
    [descr_txt] [NVARCHAR](20),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Target] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[UNIT] (
    [unit_id] [NUMERIC](20,0) NOT NULL,
    [formal_abbrd_name_txt] [NVARCHAR](100) NOT NULL,
    [identific_txt] [NVARCHAR](15),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Unit] PRIMARY KEY NONCLUSTERED 
  (
  [unit_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[UNIT_TYPE] (
    [unit_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [arm_cat_code] [NVARCHAR](6) NOT NULL,
    [arm_spclsn_code] [NVARCHAR](6),
    [suppl_spclsn_code] [NVARCHAR](6),
    [gen_mob_code] [NVARCHAR](6),
    [qual_code] [NVARCHAR](6),
    [size_code] [NVARCHAR](6) NOT NULL,
    [principal_eqpt_type_id] [NUMERIC](20,0),
    [supported_mil_org_type_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_UnitType] PRIMARY KEY NONCLUSTERED 
  (
  [unit_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[VISIBILITY] (
    [visibility_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [dir_code] [NVARCHAR](6),
    [range_dim] [NUMERIC](12,3) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Visibility] PRIMARY KEY NONCLUSTERED 
  (
  [visibility_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[WIND] (
    [wind_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [air_stability_cat_code] [NVARCHAR](6),
    [altitude_layer_code] [NVARCHAR](6),
    [dir_angle] [NUMERIC](7,4),
    [effctv_downwind_dir_angle] [NUMERIC](7,4),
    [speed_rate] [NUMERIC](8,4),
    [nuc_yield_qual_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Wind] PRIMARY KEY NONCLUSTERED 
  (
  [wind_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CFEAT_STAT] (
    [cfeat_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [invstg_stat_code] [NVARCHAR](6),
    [cbrn_thrt_lvl_code] [NVARCHAR](6),
    [security_stat_code] [NVARCHAR](6),
    [usage_stat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CfeatStat] PRIMARY KEY NONCLUSTERED 
  (
  [cfeat_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FAC_STAT] (
    [fac_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dmltn_stat_code] [NVARCHAR](6),
    [enemy_actv_cond_code] [NVARCHAR](6),
    [mine_prsnc_code] [NVARCHAR](6),
    [ocptn_prog_ind_code] [NVARCHAR](6),
    [operat_stat_code] [NVARCHAR](6) NOT NULL,
    [operat_stat_qual_code] [NVARCHAR](6),
    [reserve_ind_code] [NVARCHAR](6),
    [security_stat_code] [NVARCHAR](6),
    [usage_stat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_FacStat] PRIMARY KEY NONCLUSTERED 
  (
  [fac_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GFEAT_STAT] (
    [gfeat_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [mine_prsnc_code] [NVARCHAR](6),
    [surf_recirc_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GfeatStat] PRIMARY KEY NONCLUSTERED 
  (
  [gfeat_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MAT_STAT] (
    [mat_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [body_colour_code] [NVARCHAR](6),
    [marking_code] [NVARCHAR](6),
    [marking_colour_code] [NVARCHAR](6),
    [dmltn_stat_code] [NVARCHAR](6),
    [imo_compliant_ind_code] [NVARCHAR](6),
    [operat_stat_code] [NVARCHAR](6) NOT NULL,
    [operat_stat_qual_code] [NVARCHAR](6),
    [operat_stat_mode_code] [NVARCHAR](6),
    [reserve_ind_code] [NVARCHAR](6),
    [safety_stat_code] [NVARCHAR](6),
    [usage_stat_code] [NVARCHAR](6),
    [buoy_malf_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MatStat] PRIMARY KEY NONCLUSTERED 
  (
  [mat_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_STAT] (
    [org_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [operat_stat_code] [NVARCHAR](6) NOT NULL,
    [operat_stat_qual_code] [NVARCHAR](6),
    [avlbty_code] [NVARCHAR](6),
    [cmd_and_ctrl_role_code] [NVARCHAR](6),
    [cmtmnt_stat_code] [NVARCHAR](6),
    [fire_mode_code] [NVARCHAR](6),
    [cbrn_dress_state_code] [NVARCHAR](6),
    [rad_dose_qty] [NUMERIC](6,0),
    [rdns_code] [NVARCHAR](6),
    [rdns_dur] [NUMERIC](19,0),
    [reinforce_code] [NVARCHAR](6),
    [reserve_ind_code] [NVARCHAR](6),
    [training_code] [NVARCHAR](6),
    [usage_stat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgStat] PRIMARY KEY NONCLUSTERED 
  (
  [org_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_OI_ASSOC] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtOiAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [obj_item_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTDET] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [ctgtdet_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [focus_type_code] [NVARCHAR](6) NOT NULL,
    [label_txt] [NVARCHAR](255),
    [prio_ord] [NUMERIC](6,0),
    [scheme_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Ctgtdet] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC,
  [ctgtdet_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTDET_ASSOC] (
    [subj_ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [subj_ctgtdet_ix] [NUMERIC](20,0) NOT NULL,
    [obj_ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [obj_ctgtdet_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtdetAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_ctgtlst_id] ASC,
  [subj_ctgtdet_ix] ASC,
  [obj_ctgtlst_id] ASC,
  [obj_ctgtdet_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTDET_AUTH] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [ctgtdet_ix] [NUMERIC](20,0) NOT NULL,
    [ctgtdet_auth_ix] [NUMERIC](20,0) NOT NULL,
    [app_code] [NVARCHAR](6) NOT NULL,
    [prio_ord] [NUMERIC](6,0),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtdetAuth] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC,
  [ctgtdet_ix] ASC,
  [ctgtdet_auth_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTDET_ITEM] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [ctgtdet_item_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtdetItem] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC,
  [ctgtdet_item_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTDET_TYPE] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [ctgtdet_type_ix] [NUMERIC](20,0) NOT NULL,
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtdetType] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC,
  [ctgtdet_type_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTLST] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](80),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Ctgtlst] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTLST_ASSOC] (
    [subj_ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [obj_ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtlstAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_ctgtlst_id] ASC,
  [obj_ctgtlst_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CTGTLST_AUTH] (
    [ctgtlst_id] [NUMERIC](20,0) NOT NULL,
    [ctgtlst_auth_ix] [NUMERIC](20,0) NOT NULL,
    [ind_code] [NVARCHAR](6) NOT NULL,
    [prio_ord] [NUMERIC](6,0),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CtgtlstAuth] PRIMARY KEY NONCLUSTERED 
  (
  [ctgtlst_id] ASC,
  [ctgtlst_auth_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REF] (
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [app_dttm] [CHAR](18),
    [cntnt_cat_code] [NVARCHAR](6),
    [creation_dttm] [CHAR](18),
    [descr_txt] [NVARCHAR](255),
    [elctrnc_source_txt] [NVARCHAR](2000),
    [file_size_qty] [NUMERIC](9,0),
    [format_txt] [NVARCHAR](50),
    [lang_code] [NVARCHAR](6),
    [lifecycle_code] [NVARCHAR](6),
    [medium_type_code] [NVARCHAR](6),
    [originator_txt] [NVARCHAR](50),
    [physcl_size_txt] [NVARCHAR](50),
    [prim_loc_txt] [NVARCHAR](2000),
    [publication_dttm] [CHAR](18),
    [releasability_txt] [NVARCHAR](50),
    [short_title_txt] [NVARCHAR](50),
    [title_txt] [NVARCHAR](50),
    [trans_type_code] [NVARCHAR](6),
    [validity_period_begin_dttm] [CHAR](18),
    [validity_period_end_dttm] [CHAR](18),
    [verf_code] [NVARCHAR](6),
    [version_txt] [NVARCHAR](50),
    [security_clsfc_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Ref] PRIMARY KEY NONCLUSTERED 
  (
  [ref_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EVENT] (
    [act_event_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEvent] PRIMARY KEY NONCLUSTERED 
  (
  [act_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EVENT_STAT] (
    [act_event_id] [NUMERIC](20,0) NOT NULL,
    [act_event_stat_ix] [NUMERIC](20,0) NOT NULL,
    [compl_rat] [NUMERIC](6,5),
    [feint_ind_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEventStat] PRIMARY KEY NONCLUSTERED 
  (
  [act_event_id] ASC,
  [act_event_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_TASK] (
    [act_task_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [actv_code] [NVARCHAR](6) NOT NULL,
    [mnm_dur] [NUMERIC](19,0),
    [estimated_dur] [NUMERIC](19,0),
    [max_dur] [NUMERIC](19,0),
    [plnd_start_dttm] [CHAR](18),
    [start_qual_code] [NVARCHAR](6),
    [plnd_end_dttm] [CHAR](18),
    [end_qual_code] [NVARCHAR](6),
    [prio_code] [NVARCHAR](6),
    [entld_safety_degree_code] [NVARCHAR](6),
    [overt_covert_code] [NVARCHAR](6),
    [det_txt] [NVARCHAR](255),
    [timing_day_code] [NVARCHAR](6),
    [timing_hour_code] [NVARCHAR](6),
    [meteorological_impact_code] [NVARCHAR](6),
    [operat_lvl_code] [NVARCHAR](6),
    [ctgtlst_id] [NUMERIC](20,0),
    [org_struct_root_org_id] [NUMERIC](20,0),
    [org_struct_ix] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActTask] PRIMARY KEY NONCLUSTERED 
  (
  [act_task_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_TASK_STAT] (
    [act_task_id] [NUMERIC](20,0) NOT NULL,
    [act_task_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [compl_rat] [NUMERIC](6,5),
    [planning_ind_code] [NVARCHAR](6),
    [progress_code] [NVARCHAR](6),
    [amend_timing_code] [NVARCHAR](6),
    [app_ind_code] [NVARCHAR](6),
    [feint_ind_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActTaskStat] PRIMARY KEY NONCLUSTERED 
  (
  [act_task_id] ASC,
  [act_task_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RPTD_ABS_TIMING] (
    [rptd_abs_timing_rptd_id] [NUMERIC](20,0) NOT NULL,
    [effctv_start_dttm] [CHAR](18),
    [effctv_end_dttm] [CHAR](18),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RptdAbsTiming] PRIMARY KEY NONCLUSTERED 
  (
  [rptd_abs_timing_rptd_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RPTD_REL_TIMING] (
    [rptd_rel_timing_rptd_id] [NUMERIC](20,0) NOT NULL,
    [offset_dur] [NUMERIC](19,0) NOT NULL,
    [ref_act_task_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RptdRelTiming] PRIMARY KEY NONCLUSTERED 
  (
  [rptd_rel_timing_rptd_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RPTD] (
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [acc_code] [NVARCHAR](6),
    [cat_code] [NVARCHAR](6) NOT NULL,
    [cntg_ind_code] [NVARCHAR](6),
    [credibility_code] [NVARCHAR](6),
    [reliability_code] [NVARCHAR](6),
    [rep_dttm] [CHAR](18) NOT NULL,
    [source_type_code] [NVARCHAR](6),
    [timing_cat_code] [NVARCHAR](6) NOT NULL,
    [real_data_exer_use_only_code] [NVARCHAR](6),
    [ref_id] [NUMERIC](20,0),
    [rep_org_id] [NUMERIC](20,0) NOT NULL,
    [ent_cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Rptd] PRIMARY KEY NONCLUSTERED 
  (
  [rptd_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_RPTD_ASSOC] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtRptdAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [rptd_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_ELMT] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [contxt_elmt_ix] [NUMERIC](20,0) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtElmt] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [contxt_elmt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ICING] (
    [icing_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [sev_qual_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Icing] PRIMARY KEY NONCLUSTERED 
  (
  [icing_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_ACT_ASSOC] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [act_id] [NUMERIC](20,0) NOT NULL,
    [org_act_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18),
    [intent_txt] [NVARCHAR](4000),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgActAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC,
  [act_id] ASC,
  [org_act_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_TASK_ROE] (
    [act_task_id] [NUMERIC](20,0) NOT NULL,
    [roe_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActTaskRoe] PRIMARY KEY NONCLUSTERED 
  (
  [act_task_id] ASC,
  [roe_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_ACT_TASK_ROE_STAT] (
    [act_task_id] [NUMERIC](20,0) NOT NULL,
    [roe_id] [NUMERIC](20,0) NOT NULL,
    [org_act_task_roe_stat_org_id] [NUMERIC](20,0) NOT NULL,
    [org_act_task_roe_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_start_dttm] [CHAR](18),
    [effctv_end_dttm] [CHAR](18),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgActTaskRoeStat] PRIMARY KEY NONCLUSTERED 
  (
  [act_task_id] ASC,
  [roe_id] ASC,
  [org_act_task_roe_stat_org_id] ASC,
  [org_act_task_roe_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[TARGET_PRSNL_PROTECT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rptd_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_TargetPrsnlProtect] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_MAT_TYPE_ASSOC] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [mat_type_id] [NUMERIC](20,0) NOT NULL,
    [rptbl_type_code] [NVARCHAR](6) NOT NULL,
    [rptbl_type_txt] [NVARCHAR](6) NOT NULL,
    [rptbl_type_dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgMatTypeAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC,
  [mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [surgery_backlog_dur] [NUMERIC](19,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Mfs] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_PEND_CAS_EVAC] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_cas_evac_ix] [NUMERIC](20,0) NOT NULL,
    [dest_code] [NVARCHAR](6) NOT NULL,
    [sitting_cnt] [NUMERIC](6,0) NOT NULL,
    [stretcher_cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsPendCasEvac] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_cas_evac_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_CAS_BED_OCC] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_cas_bed_occ_ix] [NUMERIC](20,0) NOT NULL,
    [group_code] [NVARCHAR](6) NOT NULL,
    [cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsCasBedOcc] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_cas_bed_occ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_INTVL_EVAC] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_intvl_evac_ix] [NUMERIC](20,0) NOT NULL,
    [dest_code] [NVARCHAR](6) NOT NULL,
    [cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsIntvlEvac] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_intvl_evac_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_INTVL_CAS_GROUP] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_intvl_cas_group_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [completed_surgery_cnt] [NUMERIC](6,0) NOT NULL,
    [death_cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsIntvlCasGroup] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_intvl_cas_group_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_INTVL_CAS_TYPE] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_intvl_cas_type_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [arrival_cnt] [NUMERIC](6,0) NOT NULL,
    [admitted_cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsIntvlCasType] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_intvl_cas_type_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MFS_PEND_SURGERY] (
    [mfs_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mfs_pend_surgery_ix] [NUMERIC](20,0) NOT NULL,
    [triage_code] [NVARCHAR](6) NOT NULL,
    [cnt] [NUMERIC](6,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MfsPendSurgery] PRIMARY KEY NONCLUSTERED 
  (
  [mfs_id] ASC,
  [obj_item_stat_ix] ASC,
  [mfs_pend_surgery_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MOB_CAPAB] (
    [mob_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [terrain_type_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MobCapab] PRIMARY KEY NONCLUSTERED 
  (
  [mob_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACFT_TYPE] (
    [acft_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [airframe_design_code] [NVARCHAR](6),
    [model_code] [NVARCHAR](6),
    [manning_code] [NVARCHAR](6),
    [mil_civ_code] [NVARCHAR](6),
    [main_purpose_code] [NVARCHAR](6),
    [design_role_code] [NVARCHAR](6),
    [design_range_code] [NVARCHAR](6),
    [weather_qual_code] [NVARCHAR](6),
    [training_cat_code] [NVARCHAR](6),
    [load_cat_code] [NVARCHAR](6),
    [takeoff_and_lndg_code] [NVARCHAR](6),
    [wing_span_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AcftType] PRIMARY KEY NONCLUSTERED 
  (
  [acft_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ELCTRNC_EQPT_TYPE] (
    [elctrnc_eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ElctrncEqptType] PRIMARY KEY NONCLUSTERED 
  (
  [elctrnc_eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ENG_EQPT_TYPE] (
    [eng_eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_EngEqptType] PRIMARY KEY NONCLUSTERED 
  (
  [eng_eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[WEAPON_TYPE] (
    [weapon_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [calibre_txt] [NVARCHAR](15),
    [fire_guidance_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_WeaponType] PRIMARY KEY NONCLUSTERED 
  (
  [weapon_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MISC_EQPT_TYPE] (
    [misc_eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MiscEqptType] PRIMARY KEY NONCLUSTERED 
  (
  [misc_eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CBRN_EQPT_TYPE] (
    [cbrn_eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CbrnEqptType] PRIMARY KEY NONCLUSTERED 
  (
  [cbrn_eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RAILCAR_TYPE] (
    [railcar_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [gauge_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RailcarType] PRIMARY KEY NONCLUSTERED 
  (
  [railcar_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[VEHICLE_TYPE] (
    [vehicle_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_VehicleType] PRIMARY KEY NONCLUSTERED 
  (
  [vehicle_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[VESSEL_TYPE] (
    [vessel_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [magn_degaussing_code_no_qty] [NUMERIC](12,0),
    [prismatic_coefficient_rat] [NUMERIC](6,5),
    [dead_wt_qty] [NUMERIC](6,0),
    [draught_dim] [NUMERIC](12,3),
    [gross_rgstrd_tong_qty] [NUMERIC](9,0),
    [height_above_the_wtrln_dim] [NUMERIC](12,3),
    [propeller_cnt] [NUMERIC](2,0),
    [propulsion_type_code] [NVARCHAR](6),
    [operat_displ_qty] [NUMERIC](9,0),
    [max_speed_rate] [NUMERIC](8,4),
    [acoustic_merit_ix_qty] [NUMERIC](6,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_VesselType] PRIMARY KEY NONCLUSTERED 
  (
  [vessel_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BIO_MAT_TYPE] (
    [bio_mat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [persist_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_BioMatType] PRIMARY KEY NONCLUSTERED 
  (
  [bio_mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CHM_MAT_TYPE] (
    [chm_mat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [persist_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ChmMatType] PRIMARY KEY NONCLUSTERED 
  (
  [chm_mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CBRN_EVENT] (
    [cbrn_event_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [alarm_result_ind_code] [NVARCHAR](6),
    [conf_test_ind_code] [NVARCHAR](6),
    [mat_cntr_type_code] [NVARCHAR](6),
    [mat_cntr_total_cnt] [NUMERIC](4,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CbrnEvent] PRIMARY KEY NONCLUSTERED 
  (
  [cbrn_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RADACT_MAT_TYPE] (
    [radact_mat_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [prim_rad_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RadactMatType] PRIMARY KEY NONCLUSTERED 
  (
  [radact_mat_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CIV_POST_TYPE] (
    [civ_post_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CivPostType] PRIMARY KEY NONCLUSTERED 
  (
  [civ_post_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[EXCTV_MIL_ORG_TYPE] (
    [exctv_mil_org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ExctvMilOrgType] PRIMARY KEY NONCLUSTERED 
  (
  [exctv_mil_org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GOVT_ORG_TYPE] (
    [govt_org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [main_actv_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GovtOrgType] PRIMARY KEY NONCLUSTERED 
  (
  [govt_org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GROUP_ORG_TYPE] (
    [group_org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GroupOrgType] PRIMARY KEY NONCLUSTERED 
  (
  [group_org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MIL_ORG_TYPE] (
    [mil_org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [service_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MilOrgType] PRIMARY KEY NONCLUSTERED 
  (
  [mil_org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MIL_POST_TYPE] (
    [mil_post_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rank_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MilPostType] PRIMARY KEY NONCLUSTERED 
  (
  [mil_post_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PRV_SCTR_ORG_TYPE] (
    [prv_sctr_org_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [main_actv_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PrvSctrOrgType] PRIMARY KEY NONCLUSTERED 
  (
  [prv_sctr_org_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[TASK_FRMTN_TYPE] (
    [task_frmtn_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_TaskFrmtnType] PRIMARY KEY NONCLUSTERED 
  (
  [task_frmtn_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PERS_IDENTIFIC_DOC] (
    [pers_id] [NUMERIC](20,0) NOT NULL,
    [pers_identific_doc_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [no_txt] [NVARCHAR](50) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PersIdentificDoc] PRIMARY KEY NONCLUSTERED 
  (
  [pers_id] ASC,
  [pers_identific_doc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PERS_LANG_SKILL] (
    [pers_id] [NUMERIC](20,0) NOT NULL,
    [pers_lang_skill_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [gen_prof_code] [NVARCHAR](6) NOT NULL,
    [lstng_prof_lvl_code] [NVARCHAR](6),
    [rdng_prof_lvl_code] [NVARCHAR](6),
    [spkng_prof_lvl_code] [NVARCHAR](6),
    [wrtng_prof_lvl_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PersLangSkill] PRIMARY KEY NONCLUSTERED 
  (
  [pers_id] ASC,
  [pers_lang_skill_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EVENT_DET] (
    [act_event_id] [NUMERIC](20,0) NOT NULL,
    [act_event_det_ix] [NUMERIC](20,0) NOT NULL,
    [clsfc_code] [NVARCHAR](6),
    [crime_ind_code] [NVARCHAR](6),
    [txt] [NVARCHAR](255),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [intended_outcome_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEventDet] PRIMARY KEY NONCLUSTERED 
  (
  [act_event_id] ASC,
  [act_event_det_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CORRIDOR_AREA] (
    [corridor_area_id] [NUMERIC](20,0) NOT NULL,
    [width_dim] [NUMERIC](12,3) NOT NULL,
    [corridor_area_centre_line_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CorridorArea] PRIMARY KEY NONCLUSTERED 
  (
  [corridor_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ELPS] (
    [elps_id] [NUMERIC](20,0) NOT NULL,
    [elps_centre_point_id] [NUMERIC](20,0) NOT NULL,
    [elps_first_cnjg_diam_point_id] [NUMERIC](20,0) NOT NULL,
    [elps_scnd_cnjg_diam_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Elps] PRIMARY KEY NONCLUSTERED 
  (
  [elps_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORBIT_AREA] (
    [orbit_area_id] [NUMERIC](20,0) NOT NULL,
    [alignment_code] [NVARCHAR](6) NOT NULL,
    [width_dim] [NUMERIC](12,3) NOT NULL,
    [orbit_area_first_point_id] [NUMERIC](20,0) NOT NULL,
    [orbit_area_scnd_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrbitArea] PRIMARY KEY NONCLUSTERED 
  (
  [orbit_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLYRC_AREA] (
    [plyrc_area_id] [NUMERIC](20,0) NOT NULL,
    [begin_brng_angle] [NUMERIC](7,4) NOT NULL,
    [end_brng_angle] [NUMERIC](7,4) NOT NULL,
    [arc_radius_dim] [NUMERIC](12,3) NOT NULL,
    [plyrc_area_dfng_line_id] [NUMERIC](20,0) NOT NULL,
    [plyrc_area_brng_orgn_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlyrcArea] PRIMARY KEY NONCLUSTERED 
  (
  [plyrc_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POLYGON_AREA] (
    [polygon_area_id] [NUMERIC](20,0) NOT NULL,
    [polygon_area_bndg_line_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PolygonArea] PRIMARY KEY NONCLUSTERED 
  (
  [polygon_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SPHERE_VOL] (
    [sphere_vol_id] [NUMERIC](20,0) NOT NULL,
    [radius_dim] [NUMERIC](12,3) NOT NULL,
    [sphere_vol_centre_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SphereVol] PRIMARY KEY NONCLUSTERED 
  (
  [sphere_vol_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SURF_VOL] (
    [surf_vol_id] [NUMERIC](20,0) NOT NULL,
    [surf_vol_dfng_surf_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SurfVol] PRIMARY KEY NONCLUSTERED 
  (
  [surf_vol_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[TRACK_AREA] (
    [track_area_id] [NUMERIC](20,0) NOT NULL,
    [left_width_dim] [NUMERIC](12,3) NOT NULL,
    [right_width_dim] [NUMERIC](12,3) NOT NULL,
    [track_area_begin_point_id] [NUMERIC](20,0) NOT NULL,
    [track_area_end_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_TrackArea] PRIMARY KEY NONCLUSTERED 
  (
  [track_area_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[VER_DIST] (
    [ver_dist_id] [NUMERIC](20,0) NOT NULL,
    [ref_code] [NVARCHAR](6) NOT NULL,
    [dim] [NUMERIC](12,3) NOT NULL,
    [precision_code] [NVARCHAR](6),
    [datum_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_VerDist] PRIMARY KEY NONCLUSTERED 
  (
  [ver_dist_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AMMO_TYPE] (
    [ammo_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [calibre_txt] [NVARCHAR](15),
    [mine_mrt_firing_code] [NVARCHAR](6),
    [exer_mine_flare_colour_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AmmoType] PRIMARY KEY NONCLUSTERED 
  (
  [ammo_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_LOC] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [loc_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_loc_ix] [NUMERIC](20,0) NOT NULL,
    [ver_acc_dim] [NUMERIC](12,3),
    [horz_acc_dim] [NUMERIC](12,3),
    [brng_angle] [NUMERIC](7,4),
    [brng_acc_angle] [NUMERIC](7,4),
    [brng_precision_code] [NVARCHAR](6),
    [incl_angle] [NUMERIC](7,4),
    [incl_acc_angle] [NUMERIC](7,4),
    [incl_precision_code] [NVARCHAR](6),
    [speed_rate] [NUMERIC](8,4),
    [speed_acc_rate] [NUMERIC](8,4),
    [speed_precision_code] [NVARCHAR](6),
    [meaning_code] [NVARCHAR](6),
    [rel_speed_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemLoc] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [loc_id] ASC,
  [obj_item_loc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AIRFIELD] (
    [airfield_id] [NUMERIC](20,0) NOT NULL,
    [atc_prsnc_ind_code] [NVARCHAR](6),
    [hngr_area_qty] [NUMERIC](6,0),
    [ils_prsnc_ind_code] [NVARCHAR](6),
    [intl_civil_avtn_org_txt] [NVARCHAR](100),
    [visual_nvtgl_aid_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Airfield] PRIMARY KEY NONCLUSTERED 
  (
  [airfield_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BRIDGE_TYPE] (
    [bridge_type_id] [NUMERIC](20,0) NOT NULL,
    [design_type_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_BridgeType] PRIMARY KEY NONCLUSTERED 
  (
  [bridge_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REL_COORD_SYS] (
    [rel_coord_sys_id] [NUMERIC](20,0) NOT NULL,
    [ref_cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RelCoordSys] PRIMARY KEY NONCLUSTERED 
  (
  [rel_coord_sys_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_REF] (
    [rel_coord_sys_id] [NUMERIC](20,0) NOT NULL,
    [obj_ref_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_ref_loc_id] [NUMERIC](20,0) NOT NULL,
    [obj_ref_obj_item_loc_ix] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjRef] PRIMARY KEY NONCLUSTERED 
  (
  [rel_coord_sys_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POINT_REF] (
    [rel_coord_sys_id] [NUMERIC](20,0) NOT NULL,
    [point_ref_orgn_point_id] [NUMERIC](20,0) NOT NULL,
    [point_ref_x_vector_point_id] [NUMERIC](20,0) NOT NULL,
    [point_ref_y_vector_point_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PointRef] PRIMARY KEY NONCLUSTERED 
  (
  [rel_coord_sys_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NETWRK] (
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [arch_code] [NVARCHAR](6),
    [chnl_cnt] [NUMERIC](6,0),
    [max_cap_rate] [NUMERIC](8,4),
    [mnm_cap_rate] [NUMERIC](8,4),
    [means_code] [NVARCHAR](6),
    [set_no_cnt] [NUMERIC](6,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Netwrk] PRIMARY KEY NONCLUSTERED 
  (
  [netwrk_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NETWRK_FREQ] (
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [netwrk_freq_ix] [NUMERIC](20,0) NOT NULL,
    [band_code] [NVARCHAR](6),
    [chnl_no_txt] [NVARCHAR](6),
    [discrete_freq_qty] [NUMERIC](9,0),
    [band_lower_freq_qty] [NUMERIC](9,0),
    [band_upper_freq_qty] [NUMERIC](9,0),
    [effctv_start_dttm] [CHAR](18) NOT NULL,
    [effctv_end_dttm] [CHAR](18),
    [mdltn_code] [NVARCHAR](6),
    [purpose_txt] [NVARCHAR](255),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NetwrkFreq] PRIMARY KEY NONCLUSTERED 
  (
  [netwrk_id] ASC,
  [netwrk_freq_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NETWRK_SERVICE] (
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [netwrk_service_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [crypto_ind_code] [NVARCHAR](6),
    [crypto_plan_short_title_txt] [NVARCHAR](50),
    [crypto_code_short_title_txt] [NVARCHAR](50),
    [iff_mode_code_txt] [NVARCHAR](50),
    [security_clsfc_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NetwrkService] PRIMARY KEY NONCLUSTERED 
  (
  [netwrk_id] ASC,
  [netwrk_service_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[UXO_STAT] (
    [uxo_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [exp_code] [NVARCHAR](6) NOT NULL,
    [qual_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_UxoStat] PRIMARY KEY NONCLUSTERED 
  (
  [uxo_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EFFECT_ITEM] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_effect_ix] [NUMERIC](20,0) NOT NULL,
    [rat] [NUMERIC](6,5) NOT NULL,
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEffectItem] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_effect_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_EFFECT_TYPE] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_effect_ix] [NUMERIC](20,0) NOT NULL,
    [cnt] [NUMERIC](6,0) NOT NULL,
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActEffectType] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_effect_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_ADDR] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [addr_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_addr_ix] [NUMERIC](20,0) NOT NULL,
    [call_sign_txt] [NVARCHAR](50),
    [primacy_code] [NVARCHAR](6),
    [auth_ind_code] [NVARCHAR](6),
    [trns_rcv_code] [NVARCHAR](6),
    [netwrk_id] [NUMERIC](20,0),
    [netwrk_freq_ix] [NUMERIC](20,0),
    [rptd_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemAddr] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [addr_id] ASC,
  [obj_item_addr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ADDR] (
    [addr_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [place_name_txt] [NVARCHAR](100),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Addr] PRIMARY KEY NONCLUSTERED 
  (
  [addr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ELCTRNC_ADDR] (
    [addr_id] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [netwrk_service_ix] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ElctrncAddr] PRIMARY KEY NONCLUSTERED 
  (
  [addr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PHYSCL_ADDR] (
    [addr_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rsdnc_txt] [NVARCHAR](50),
    [street_txt] [NVARCHAR](50),
    [street_addtnl_txt] [NVARCHAR](50),
    [postal_box_txt] [NVARCHAR](15),
    [postbox_id_txt] [NVARCHAR](15),
    [city_txt] [NVARCHAR](50),
    [geo_txt] [NVARCHAR](50),
    [postal_code_txt] [NVARCHAR](15),
    [province_txt] [NVARCHAR](50),
    [district_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PhysclAddr] PRIMARY KEY NONCLUSTERED 
  (
  [addr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_ASSOC] (
    [subj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [act_task_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_obj_item_id] ASC,
  [obj_obj_item_id] ASC,
  [obj_item_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_ASSOC_STAT] (
    [subj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_assoc_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemAssocStat] PRIMARY KEY NONCLUSTERED 
  (
  [subj_obj_item_id] ASC,
  [obj_obj_item_id] ASC,
  [obj_item_assoc_ix] ASC,
  [obj_item_assoc_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_STRUCT] (
    [org_struct_root_org_id] [NUMERIC](20,0) NOT NULL,
    [org_struct_ix] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](100),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgStruct] PRIMARY KEY NONCLUSTERED 
  (
  [org_struct_root_org_id] ASC,
  [org_struct_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_STRUCT_DET] (
    [org_struct_root_org_id] [NUMERIC](20,0) NOT NULL,
    [org_struct_ix] [NUMERIC](20,0) NOT NULL,
    [org_struct_det_ix] [NUMERIC](20,0) NOT NULL,
    [subj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgStructDet] PRIMARY KEY NONCLUSTERED 
  (
  [org_struct_root_org_id] ASC,
  [org_struct_ix] ASC,
  [org_struct_det_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE_ITEM_MARKING] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [act_objve_item_marking_ix] [NUMERIC](20,0) NOT NULL,
    [laser_correlation_code_txt] [NVARCHAR](4),
    [method_code] [NVARCHAR](6),
    [panel_shape_code] [NVARCHAR](6),
    [rcgn_sgnl_colour_code] [NVARCHAR](6),
    [start_dttm] [CHAR](18),
    [using_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjveItemMarking] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC,
  [act_objve_item_marking_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MIL_OBS_TYPE] (
    [mil_obs_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MilObsType] PRIMARY KEY NONCLUSTERED 
  (
  [mil_obs_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MIL_OBS] (
    [mil_obs_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MilObs] PRIMARY KEY NONCLUSTERED 
  (
  [mil_obs_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NETWRK_CAP] (
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [netwrk_cap_ix] [NUMERIC](20,0) NOT NULL,
    [bandwidth_code] [NVARCHAR](6),
    [protocol_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NetwrkCap] PRIMARY KEY NONCLUSTERED 
  (
  [netwrk_id] ASC,
  [netwrk_cap_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GROUP_CHRCT] (
    [group_chrct_id] [NUMERIC](20,0) NOT NULL,
    [age_group_code] [NVARCHAR](6),
    [malady_code] [NVARCHAR](6),
    [malady_trnsmsbl_ind_code] [NVARCHAR](6),
    [gender_code] [NVARCHAR](6),
    [lang_code] [NVARCHAR](6),
    [triage_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GroupChrct] PRIMARY KEY NONCLUSTERED 
  (
  [group_chrct_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_GROUP_ACCT] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_group_acct_ix] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [act_id] [NUMERIC](20,0),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemGroupAcct] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_group_acct_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_GROUP_ACCT_DET] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_group_acct_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_group_acct_det_ix] [NUMERIC](20,0) NOT NULL,
    [cnt] [NUMERIC](9,0) NOT NULL,
    [qual_code] [NVARCHAR](6),
    [group_chrct_id] [NUMERIC](20,0),
    [pers_type_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemGroupAcctDet] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_group_acct_ix] ASC,
  [obj_item_group_acct_det_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AFFL] (
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Affl] PRIMARY KEY NONCLUSTERED 
  (
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AFFL_ETHNIC_GROUP] (
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AfflEthnicGroup] PRIMARY KEY NONCLUSTERED 
  (
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AFFL_FUNCTL_GROUP] (
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](50) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AfflFunctlGroup] PRIMARY KEY NONCLUSTERED 
  (
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AFFL_GEOPOLITICAL] (
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AfflGeopolitical] PRIMARY KEY NONCLUSTERED 
  (
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AFFL_RELIGION] (
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AfflReligion] PRIMARY KEY NONCLUSTERED 
  (
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_AFFL] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_affl_ix] [NUMERIC](20,0) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemAffl] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [affl_id] ASC,
  [obj_item_affl_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE_AFFL] (
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [affl_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjTypeAffl] PRIMARY KEY NONCLUSTERED 
  (
  [obj_type_id] ASC,
  [affl_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[HRBR] (
    [hrbr_id] [NUMERIC](20,0) NOT NULL,
    [airport_near_ind_code] [NVARCHAR](6),
    [appr_chnl_depth_dim] [NUMERIC](12,3),
    [biolg_secure_avlbty_ind_code] [NVARCHAR](6),
    [convoy_mrshl_ind_code] [NVARCHAR](6),
    [day_limit_net_expl_qty] [NUMERIC](6,0),
    [night_limit_net_expl_qty] [NUMERIC](6,0),
    [degaussing_ind_code] [NVARCHAR](6),
    [dirty_ballast_ind_code] [NVARCHAR](6),
    [entr_restr_ice_ind_code] [NVARCHAR](6),
    [entr_restr_swell_ind_code] [NVARCHAR](6),
    [entr_restr_txt] [NVARCHAR](100),
    [eta_ind_code] [NVARCHAR](6),
    [fire_fighting_capab_code] [NVARCHAR](6),
    [fire_fighting_ind_code] [NVARCHAR](6),
    [first_port_of_entry_ind_code] [NVARCHAR](6),
    [fresh_water_avlbty_ind_code] [NVARCHAR](6),
    [lash_ind_code] [NVARCHAR](6),
    [lighterage_avlbty_ind_code] [NVARCHAR](6),
    [max_vessel_draught_dim] [NUMERIC](12,3),
    [max_vessel_length_dim] [NUMERIC](12,3),
    [max_vessel_width_dim] [NUMERIC](12,3),
    [mean_tidal_curr_rate] [NUMERIC](7,1),
    [psgr_hndl_ind_code] [NVARCHAR](6),
    [persistence_code] [NVARCHAR](6),
    [overhead_limits_ind_code] [NVARCHAR](6),
    [pilotage_avlbty_ind_code] [NVARCHAR](6),
    [pilotage_reqmnt_ind_code] [NVARCHAR](6),
    [prvl_wind_dir_code] [NVARCHAR](6),
    [prvl_wind_max_speed_code] [NVARCHAR](6),
    [prvl_wind_max_speed_rate] [NUMERIC](4,1),
    [refl_avlbty_ind_code] [NVARCHAR](6),
    [refl_loc_txt] [NVARCHAR](255),
    [refl_type_code] [NVARCHAR](6),
    [seasonal_det_txt] [NVARCHAR](255),
    [shelter_qual_code] [NVARCHAR](6),
    [tanker_facilities_ind_code] [NVARCHAR](6),
    [tidal_mean_neap_range_dim] [NUMERIC](12,3),
    [tidal_mean_spring_range_dim] [NUMERIC](12,3),
    [tidal_txt] [NVARCHAR](255),
    [trnst_acom_ind_code] [NVARCHAR](6),
    [tug_avlbty_ind_code] [NVARCHAR](6),
    [turning_area_ind_code] [NVARCHAR](6),
    [vehicle_hndl_type_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Hrbr] PRIMARY KEY NONCLUSTERED 
  (
  [hrbr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ANCHR] (
    [anchr_id] [NUMERIC](20,0) NOT NULL,
    [btm_type_code] [NVARCHAR](6),
    [day_limit_net_expl_qty] [NUMERIC](6,0),
    [draught_high_tide_dim] [NUMERIC](12,3),
    [draught_low_tide_dim] [NUMERIC](12,3),
    [moorings_type_code] [NVARCHAR](6),
    [night_limit_net_expl_qty] [NUMERIC](6,0),
    [prvl_wind_dir_code] [NVARCHAR](6),
    [vessel_tong_qty] [NUMERIC](9,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Anchr] PRIMARY KEY NONCLUSTERED 
  (
  [anchr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BASIN] (
    [basin_id] [NUMERIC](20,0) NOT NULL,
    [ddw_tong_qty] [NUMERIC](9,0),
    [depth_dim] [NUMERIC](12,3),
    [loc_txt] [NVARCHAR](255),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Basin] PRIMARY KEY NONCLUSTERED 
  (
  [basin_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BERTH] (
    [berth_id] [NUMERIC](20,0) NOT NULL,
    [ddw_tong_qty] [NUMERIC](9,0),
    [depth_dim] [NUMERIC](12,3),
    [loc_txt] [NVARCHAR](255),
    [major_vessel_class_code] [NVARCHAR](6),
    [max_beam_dim] [NUMERIC](12,3),
    [max_cap_qty] [NUMERIC](6,0),
    [max_vessel_cnt] [NUMERIC](2,0),
    [day_limit_net_expl_qty] [NUMERIC](6,0),
    [night_limit_net_expl_qty] [NUMERIC](6,0),
    [rail_avlbty_ind_code] [NVARCHAR](6),
    [roll_on_roll_off_ind_code] [NVARCHAR](6),
    [turnaround_time_dur] [NUMERIC](19,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Berth] PRIMARY KEY NONCLUSTERED 
  (
  [berth_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[DRY_DOCK] (
    [dry_dock_id] [NUMERIC](20,0) NOT NULL,
    [boat_lift_cap_qty] [NUMERIC](9,0),
    [depth_dim] [NUMERIC](12,3),
    [loc_txt] [NVARCHAR](255),
    [marine_railway_size_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_DryDock] PRIMARY KEY NONCLUSTERED 
  (
  [dry_dock_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[JETTY] (
    [jetty_id] [NUMERIC](20,0) NOT NULL,
    [day_limit_net_expl_qty] [NUMERIC](6,0),
    [max_ddw_tong_qty] [NUMERIC](9,0),
    [max_draught_dim] [NUMERIC](12,3),
    [night_limit_net_expl_qty] [NUMERIC](6,0),
    [rail_cap_cnt] [NUMERIC](6,0),
    [rail_served_ind_code] [NVARCHAR](6),
    [vessel_max_beam_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Jetty] PRIMARY KEY NONCLUSTERED 
  (
  [jetty_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[QUAY] (
    [quay_id] [NUMERIC](20,0) NOT NULL,
    [cntr_hndl_type_code] [NVARCHAR](6),
    [cntr_max_hndl_length_dim] [NUMERIC](12,3),
    [cntr_max_hndl_wt_qty] [NUMERIC](9,0),
    [crane_ofld_lift_qty] [NUMERIC](9,0),
    [crane_ofld_type_code] [NVARCHAR](6),
    [day_limit_net_expl_qty] [NUMERIC](6,0),
    [draught_dim] [NUMERIC](12,3),
    [max_ddw_tong_qty] [NUMERIC](9,0),
    [night_limit_net_expl_qty] [NUMERIC](6,0),
    [rail_cap_cnt] [NUMERIC](9,0),
    [rail_served_ind_code] [NVARCHAR](6),
    [storage_code] [NVARCHAR](6),
    [vessel_max_beam_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Quay] PRIMARY KEY NONCLUSTERED 
  (
  [quay_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SLPWAY] (
    [slpway_id] [NUMERIC](20,0) NOT NULL,
    [gradient_angle] [NUMERIC](7,4),
    [loc_txt] [NVARCHAR](255),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Slpway] PRIMARY KEY NONCLUSTERED 
  (
  [slpway_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_OBJ_TYPE_ESTAB] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [estabd_obj_type_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_estab_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_obj_type_estab_ix] [NUMERIC](20,0) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemObjTypeEstab] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [estabd_obj_type_id] ASC,
  [obj_type_estab_ix] ASC,
  [obj_item_obj_type_estab_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE_ESTAB] (
    [estabd_obj_type_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_estab_ix] [NUMERIC](20,0) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [environ_cond_code] [NVARCHAR](6),
    [name_txt] [NVARCHAR](80),
    [operat_mode_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjTypeEstab] PRIMARY KEY NONCLUSTERED 
  (
  [estabd_obj_type_id] ASC,
  [obj_type_estab_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE_ESTAB_OBJT_DET] (
    [estabd_obj_type_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_estab_ix] [NUMERIC](20,0) NOT NULL,
    [obj_type_estab_objt_det_ix] [NUMERIC](20,0) NOT NULL,
    [major_part_ind_code] [NVARCHAR](6),
    [cnt] [NUMERIC](9,0) NOT NULL,
    [det_obj_type_id] [NUMERIC](20,0) NOT NULL,
    [det_obj_type_estab_ix] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjTypeEstabObjtDet] PRIMARY KEY NONCLUSTERED 
  (
  [estabd_obj_type_id] ASC,
  [obj_type_estab_ix] ASC,
  [obj_type_estab_objt_det_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RUNWAY] (
    [runway_id] [NUMERIC](20,0) NOT NULL,
    [lgtng_prsnc_ind_code] [NVARCHAR](6),
    [wt_brng_cap_qty] [NUMERIC](8,4),
    [pvm_clsfc_no_cnt] [NUMERIC](9,0),
    [pvm_type_code] [NVARCHAR](6),
    [pvm_subgrade_cat_code] [NVARCHAR](6),
    [pvm_max_tyre_prs_code] [NVARCHAR](6),
    [pvm_eval_method_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Runway] PRIMARY KEY NONCLUSTERED 
  (
  [runway_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD_LAND] (
    [mnfld_land_id] [NUMERIC](20,0) NOT NULL,
    [depth_plcmnt_code] [NVARCHAR](6),
    [func_code] [NVARCHAR](6),
    [pattern_code] [NVARCHAR](6),
    [persistence_code] [NVARCHAR](6),
    [stopping_power_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MnfldLand] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_land_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD_MRT] (
    [mnfld_mrt_id] [NUMERIC](20,0) NOT NULL,
    [depth_plcmnt_code] [NVARCHAR](6),
    [expct_vessel_transit_cnt] [NUMERIC](6,0),
    [func_code] [NVARCHAR](6),
    [mmoe_initial_thrt_prob_rat] [NUMERIC](6,5),
    [dtctn_prob_rat] [NUMERIC](6,5),
    [life_dur] [NUMERIC](19,0),
    [mine_detld_txt] [NVARCHAR](50),
    [mines_laid_cnt] [NUMERIC](6,0),
    [btm_natural_camo_code] [NVARCHAR](6),
    [subf_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MnfldMrt] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_mrt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD_MRT_CAS_EST] (
    [mnfld_mrt_id] [NUMERIC](20,0) NOT NULL,
    [mnfld_mrt_cas_est_ix] [NUMERIC](20,0) NOT NULL,
    [avg_cnt] [NUMERIC](6,0),
    [given_transit_cnt] [NUMERIC](6,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MnfldMrtCasEst] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_mrt_id] ASC,
  [mnfld_mrt_cas_est_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD_MRT_SUST_THRT_MOE] (
    [mnfld_mrt_id] [NUMERIC](20,0) NOT NULL,
    [mnfld_mrt_sust_thrt_moe_ix] [NUMERIC](20,0) NOT NULL,
    [plnd_dur] [NUMERIC](19,0),
    [prob_rat] [NUMERIC](6,5),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MnfldMrtSustThrtMoe] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_mrt_id] ASC,
  [mnfld_mrt_sust_thrt_moe_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LQD_SURF_STAT] (
    [lqd_surf_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [sea_state_code] [NVARCHAR](6),
    [surf_cond_code] [NVARCHAR](6),
    [wave_dir_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_LqdSurfStat] PRIMARY KEY NONCLUSTERED 
  (
  [lqd_surf_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SLD_SURF_STAT] (
    [sld_surf_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [dmltn_stat_code] [NVARCHAR](6),
    [surf_cond_code] [NVARCHAR](6),
    [surf_firm_code] [NVARCHAR](6),
    [veg_cat_code] [NVARCHAR](6),
    [veg_subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SldSurfStat] PRIMARY KEY NONCLUSTERED 
  (
  [sld_surf_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AIRFIELD_STAT] (
    [airfield_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [day_opers_code] [NVARCHAR](6),
    [flight_supp_cat_code] [NVARCHAR](6),
    [eval_ind_code] [NVARCHAR](6),
    [max_nbac_thpt_cnt] [NUMERIC](4,0),
    [max_nbac_park_cnt] [NUMERIC](4,0),
    [max_wbac_thpt_cnt] [NUMERIC](4,0),
    [max_wbac_park_cnt] [NUMERIC](4,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AirfieldStat] PRIMARY KEY NONCLUSTERED 
  (
  [airfield_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CRTS_POINT] (
    [crts_point_id] [NUMERIC](20,0) NOT NULL,
    [x_coord_dim] [NUMERIC](12,3) NOT NULL,
    [y_coord_dim] [NUMERIC](12,3) NOT NULL,
    [z_coord_dim] [NUMERIC](12,3) NOT NULL,
    [x_precision_code] [NVARCHAR](6),
    [y_precision_code] [NVARCHAR](6),
    [z_precision_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CrtsPoint] PRIMARY KEY NONCLUSTERED 
  (
  [crts_point_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[GEO_POINT] (
    [geo_point_id] [NUMERIC](20,0) NOT NULL,
    [lat_coord] [NUMERIC](9,6) NOT NULL,
    [long_coord] [NUMERIC](10,6) NOT NULL,
    [lat_precision_code] [NVARCHAR](6),
    [long_precision_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_GeoPoint] PRIMARY KEY NONCLUSTERED 
  (
  [geo_point_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AIR_ROUTE_SGMNT] (
    [air_route_sgmnt_id] [NUMERIC](20,0) NOT NULL,
    [req_nvgtn_perf_code] [NVARCHAR](6) NOT NULL,
    [civil_mil_code] [NVARCHAR](6),
    [intl_route_code] [NVARCHAR](6),
    [mntnd_speed_rate] [NUMERIC](8,4),
    [descr_txt] [NVARCHAR](255),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AirRouteSgmnt] PRIMARY KEY NONCLUSTERED 
  (
  [air_route_sgmnt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ROUTE_TYPE] (
    [route_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RouteType] PRIMARY KEY NONCLUSTERED 
  (
  [route_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ARSP_CTRL_MEANS] (
    [arsp_ctrl_means_id] [NUMERIC](20,0) NOT NULL,
    [trnst_instr_txt] [NVARCHAR](100),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ArspCtrlMeans] PRIMARY KEY NONCLUSTERED 
  (
  [arsp_ctrl_means_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_REF_ASSOC] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [part_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActRefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [ref_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CAPAB_REF_ASSOC] (
    [capab_id] [NUMERIC](20,0) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CapabRefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [capab_id] ASC,
  [ref_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_REF_ASSOC] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_ref_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [specific_part_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemRefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [ref_id] ASC,
  [obj_item_ref_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_TYPE_REF_ASSOC] (
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjTypeRefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [obj_type_id] ASC,
  [ref_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_REF_ASSOC] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [org_ref_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [start_dttm] [CHAR](18),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgRefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC,
  [ref_id] ASC,
  [org_ref_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REF_ASSOC] (
    [subj_ref_id] [NUMERIC](20,0) NOT NULL,
    [obj_ref_id] [NUMERIC](20,0) NOT NULL,
    [ref_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RefAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_ref_id] ASC,
  [obj_ref_id] ASC,
  [ref_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_ALIAS] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_alias_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemAlias] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_alias_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_CONTXT_STAT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [act_contxt_ix] [NUMERIC](20,0) NOT NULL,
    [act_contxt_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActContxtStat] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [contxt_id] ASC,
  [act_contxt_ix] ASC,
  [act_contxt_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_ASSOC] (
    [subj_contxt_id] [NUMERIC](20,0) NOT NULL,
    [obj_contxt_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [subj_contxt_id] ASC,
  [obj_contxt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_ASSOC_STAT] (
    [subj_contxt_id] [NUMERIC](20,0) NOT NULL,
    [obj_contxt_id] [NUMERIC](20,0) NOT NULL,
    [contxt_assoc_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtAssocStat] PRIMARY KEY NONCLUSTERED 
  (
  [subj_contxt_id] ASC,
  [obj_contxt_id] ASC,
  [contxt_assoc_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_ELMT_STAT] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [contxt_elmt_ix] [NUMERIC](20,0) NOT NULL,
    [contxt_elmt_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtElmtStat] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [contxt_elmt_ix] ASC,
  [contxt_elmt_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CONTXT_OI_ASSOC_STAT] (
    [contxt_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [contxt_oi_assoc_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ContxtOiAssocStat] PRIMARY KEY NONCLUSTERED 
  (
  [contxt_id] ASC,
  [obj_item_id] ASC,
  [contxt_oi_assoc_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OIG_ORG_ASSOC] (
    [oig_id] [NUMERIC](20,0) NOT NULL,
    [org_id] [NUMERIC](20,0) NOT NULL,
    [oig_org_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OigOrgAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [oig_id] ASC,
  [org_id] ASC,
  [oig_org_assoc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OIG] (
    [oig_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Oig] PRIMARY KEY NONCLUSTERED 
  (
  [oig_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OIG_ORG_ASSOC_STAT] (
    [oig_id] [NUMERIC](20,0) NOT NULL,
    [org_id] [NUMERIC](20,0) NOT NULL,
    [oig_org_assoc_ix] [NUMERIC](20,0) NOT NULL,
    [oig_org_assoc_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [effctv_dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OigOrgAssocStat] PRIMARY KEY NONCLUSTERED 
  (
  [oig_id] ASC,
  [org_id] ASC,
  [oig_org_assoc_ix] ASC,
  [oig_org_assoc_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_LOC] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [loc_id] [NUMERIC](20,0) NOT NULL,
    [act_loc_ix] [NUMERIC](20,0) NOT NULL,
    [acc_dim] [NUMERIC](12,3),
    [brng_angle] [NUMERIC](7,4),
    [rptd_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActLoc] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [loc_id] ASC,
  [act_loc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE_TASK] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [act_objve_task_act_task_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjveTask] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_RECCE_EMPLOY] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [act_res_employ_ix] [NUMERIC](20,0) NOT NULL,
    [img_cvrg_mode_code] [NVARCHAR](6),
    [img_view_qual_code] [NVARCHAR](6),
    [type_of_cvrg_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActRecceEmploy] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC,
  [act_res_employ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_OBJVE_TYPE_IMGRY_PROD] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_objve_ix] [NUMERIC](20,0) NOT NULL,
    [img_scale_cnt] [NUMERIC](9,0),
    [img_type_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActObjveTypeImgryProd] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_objve_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NETWRK_SERVICE_STAT] (
    [netwrk_id] [NUMERIC](20,0) NOT NULL,
    [netwrk_service_ix] [NUMERIC](20,0) NOT NULL,
    [netwrk_service_stat_ix] [NUMERIC](20,0) NOT NULL,
    [ind_code] [NVARCHAR](6),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NetwrkServiceStat] PRIMARY KEY NONCLUSTERED 
  (
  [netwrk_id] ASC,
  [netwrk_service_ix] ASC,
  [netwrk_service_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AIRFIELD_TYPE] (
    [airfield_type_id] [NUMERIC](20,0) NOT NULL,
    [use_cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_AirfieldType] PRIMARY KEY NONCLUSTERED 
  (
  [airfield_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ROUTE_SGMNT] (
    [route_sgmnt_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [mob_code] [NVARCHAR](6),
    [mode_of_trnsp_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RouteSgmnt] PRIMARY KEY NONCLUSTERED 
  (
  [route_sgmnt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RAILWAY] (
    [railway_id] [NUMERIC](20,0) NOT NULL,
    [track_gauge_code] [NVARCHAR](6),
    [track_cnt] [NUMERIC](4,0),
    [train_density_cnt] [NUMERIC](4,0),
    [block_dist_dim] [NUMERIC](12,3),
    [sleeper_density_dim] [NUMERIC](12,3),
    [gross_trailing_load_qty] [NUMERIC](9,0),
    [max_speed_rate] [NUMERIC](4,1),
    [traction_sys_code] [NVARCHAR](6),
    [signal_sys_code] [NVARCHAR](6),
    [signal_sys_effc_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Railway] PRIMARY KEY NONCLUSTERED 
  (
  [railway_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ROAD] (
    [road_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [shoulder_width_code] [NVARCHAR](6),
    [traffic_density_cnt] [NUMERIC](4,0),
    [weather_cond_cat_code] [NVARCHAR](6),
    [quality_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Road] PRIMARY KEY NONCLUSTERED 
  (
  [road_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[APRON] (
    [apron_id] [NUMERIC](20,0) NOT NULL,
    [wt_brng_cap_qty] [NUMERIC](8,4),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Apron] PRIMARY KEY NONCLUSTERED 
  (
  [apron_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CHM_BIO_EVENT] (
    [chm_bio_event_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [release_cat_code] [NVARCHAR](6),
    [spill_size_code] [NVARCHAR](6),
    [release_height_dim] [NUMERIC](12,3),
    [vol_cncntr_qty] [NUMERIC](14,6),
    [surf_dep_qty] [NUMERIC](14,6),
    [atmspc_prtcl_cncntr_qty] [NUMERIC](14,6),
    [mass_frac_cncntr_qty] [NUMERIC](14,6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ChmBioEvent] PRIMARY KEY NONCLUSTERED 
  (
  [chm_bio_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NUC_EVENT] (
    [nuc_event_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NucEvent] PRIMARY KEY NONCLUSTERED 
  (
  [nuc_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NUC_WEAPON_EVENT] (
    [nuc_weapon_event_id] [NUMERIC](20,0) NOT NULL,
    [flash_to_bang_dur] [NUMERIC](19,0),
    [crater_prsnc_code] [NVARCHAR](6),
    [crater_width_dim] [NUMERIC](12,3),
    [yield_group_code] [NVARCHAR](6),
    [yield_qty] [NUMERIC](4,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_NucWeaponEvent] PRIMARY KEY NONCLUSTERED 
  (
  [nuc_weapon_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RADACT_EVENT] (
    [radact_event_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dose_qty] [NUMERIC](14,6),
    [dose_rate] [NUMERIC](16,7),
    [dose_rate_trend_code] [NVARCHAR](6),
    [vol_cncntr_qty] [NUMERIC](14,6),
    [surf_dep_qty] [NUMERIC](14,6),
    [rel_decay_rate_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RadactEvent] PRIMARY KEY NONCLUSTERED 
  (
  [radact_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RADLGC_EVENT] (
    [radlgc_event_id] [NUMERIC](20,0) NOT NULL,
    [release_cat_code] [NVARCHAR](6),
    [isotope_cncntr_rat] [NUMERIC](6,5),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RadlgcEvent] PRIMARY KEY NONCLUSTERED 
  (
  [radlgc_event_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_ELCTRNC_WARFARE_EMPLOY] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [act_res_employ_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActElctrncWarfareEmploy] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC,
  [act_res_employ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[APPR_DIR] (
    [appr_dir_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6),
    [angle_txt] [NVARCHAR](3) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ApprDir] PRIMARY KEY NONCLUSTERED 
  (
  [appr_dir_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[RUNWAY_APPR_DIR_ASSOC] (
    [runway_id] [NUMERIC](20,0) NOT NULL,
    [appr_dir_id] [NUMERIC](20,0) NOT NULL,
    [slope_rat] [NUMERIC](6,5),
    [lndg_dist_dim] [NUMERIC](12,3),
    [takeoff_dist_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_RunwayApprDirAssoc] PRIMARY KEY NONCLUSTERED 
  (
  [runway_id] ASC,
  [appr_dir_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MRT_EQPT_TYPE] (
    [mrt_eqpt_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [subcat_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MrtEqptType] PRIMARY KEY NONCLUSTERED 
  (
  [mrt_eqpt_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SURF_VESSEL_TYPE] (
    [surf_vessel_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [displ_qty] [NUMERIC](9,0),
    [max_deck_load_qty] [NUMERIC](9,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SurfVesselType] PRIMARY KEY NONCLUSTERED 
  (
  [surf_vessel_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SUBSURF_VESSEL_TYPE] (
    [subsurf_vessel_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dived_displ_qty] [NUMERIC](9,0),
    [speed_cavitation_qty] [NUMERIC](3,0),
    [torpedo_loading_gear_ind_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SubsurfVesselType] PRIMARY KEY NONCLUSTERED 
  (
  [subsurf_vessel_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[HRBR_TYPE] (
    [hrbr_type_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_HrbrType] PRIMARY KEY NONCLUSTERED 
  (
  [hrbr_type_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[INST_LNDG_SYS] (
    [inst_lndg_sys_id] [NUMERIC](20,0) NOT NULL,
    [beam_width_dim] [NUMERIC](12,3),
    [glide_path_angle] [NUMERIC](7,4),
    [magn_varn_angle] [NUMERIC](7,4),
    [slaved_varn_angle] [NUMERIC](7,4),
    [brng_angle] [NUMERIC](7,4),
    [thrsh_crsn_height_dim] [NUMERIC](12,3),
    [localizer_dist_dim] [NUMERIC](12,3),
    [dist_mesn_eqpt_dist_dim] [NUMERIC](12,3),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_InstLndgSys] PRIMARY KEY NONCLUSTERED 
  (
  [inst_lndg_sys_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNFLD_MRT_STAT] (
    [mnfld_mrt_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6),
    [colour_code] [NVARCHAR](6),
    [expct_lvl_mcm_code] [NVARCHAR](6),
    [mines_detected_qty] [NUMERIC](6,0),
    [mines_detected_cnt] [NUMERIC](6,0),
    [mine_zone_risk_code] [NVARCHAR](6),
    [seeding_code] [NVARCHAR](6),
    [swept_depth_qty] [NUMERIC](12,3),
    [thrt_rat] [NUMERIC](6,5),
    [mine_dtctn_code] [NVARCHAR](6),
    [mines_cnt] [NUMERIC](6,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MnfldMrtStat] PRIMARY KEY NONCLUSTERED 
  (
  [mnfld_mrt_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[LQD_BODY_STAT] (
    [lqd_body_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [btm_curr_rate] [NUMERIC](4,1),
    [thermal_layer_depth_qty] [NUMERIC](4,0),
    [tidal_stream_rate] [NUMERIC](4,1),
    [underwater_visibility_qty] [NUMERIC](4,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_LqdBodyStat] PRIMARY KEY NONCLUSTERED 
  (
  [lqd_body_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[HOLDING_TRNSF] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_type_id] [NUMERIC](20,0) NOT NULL,
    [holding_ix] [NUMERIC](20,0) NOT NULL,
    [holding_trnsf_ix] [NUMERIC](20,0) NOT NULL,
    [reason_code] [NVARCHAR](6) NOT NULL,
    [qty] [NUMERIC](9,0) NOT NULL,
    [holding_trnsf_crsp_obj_item_id] [NUMERIC](20,0),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_HoldingTrnsf] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_type_id] ASC,
  [holding_ix] ASC,
  [holding_trnsf_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_MRT_EMPLOY] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_res_ix] [NUMERIC](20,0) NOT NULL,
    [act_res_employ_ix] [NUMERIC](20,0) NOT NULL,
    [casp_code] [NVARCHAR](6),
    [no_runs_req_cnt] [NUMERIC](3,0),
    [swept_lane_actu_width_dim] [NUMERIC](12,3),
    [vessel_trnst_instr_code] [NVARCHAR](6),
    [vessel_trnst_rcmdd_speed_rate] [NUMERIC](8,4),
    [vessel_trnst_lngtd_spc_dim] [NUMERIC](12,3),
    [grp_vessel_trnst_lngtd_spc_dim] [NUMERIC](12,3),
    [lead_vessel_name_txt] [NVARCHAR](50),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActMrtEmploy] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_res_ix] ASC,
  [act_res_employ_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MINE_STAT] (
    [mine_stat_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_stat_ix] [NUMERIC](20,0) NOT NULL,
    [mine_buried_rat] [NUMERIC](6,5),
    [code] [NVARCHAR](6),
    [air_drop_effect_code] [NVARCHAR](6),
    [mrt_mine_qual_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MineStat] PRIMARY KEY NONCLUSTERED 
  (
  [mine_stat_id] ASC,
  [obj_item_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[HNDL_CAPAB] (
    [hndl_capab_id] [NUMERIC](20,0) NOT NULL,
    [cargo_cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [act_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_HndlCapab] PRIMARY KEY NONCLUSTERED 
  (
  [hndl_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[MNT_CAPAB] (
    [mnt_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [station_cnt] [NUMERIC](4,0),
    [lvl_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_MntCapab] PRIMARY KEY NONCLUSTERED 
  (
  [mnt_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SUPP_CAPAB] (
    [supp_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SuppCapab] PRIMARY KEY NONCLUSTERED 
  (
  [supp_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[TRNSM_CAPAB] (
    [trnsm_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dscpt_code] [NVARCHAR](6),
    [elctrnc_eqpt_type_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_TrnsmCapab] PRIMARY KEY NONCLUSTERED 
  (
  [trnsm_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OPERAT_CAPAB] (
    [operat_capab_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [lvl_code] [NVARCHAR](6),
    [qual_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OperatCapab] PRIMARY KEY NONCLUSTERED 
  (
  [operat_capab_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_HSTLY_STAT] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_hstly_stat_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemHstlyStat] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_hstly_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SECURITY_CLSFC] (
    [security_clsfc_id] [NUMERIC](20,0) NOT NULL,
    [lvl_code] [NVARCHAR](6) NOT NULL,
    [policy_txt] [NVARCHAR](100),
    [caveat_txt] [NVARCHAR](100),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_SecurityClsfc] PRIMARY KEY NONCLUSTERED 
  (
  [security_clsfc_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CMPNT_HDR_CNTNT] (
    [cmpnt_hdr_cntnt_id] [NUMERIC](20,0) NOT NULL,
    [topic_heading_txt] [NVARCHAR](255) NOT NULL,
    [security_clsfc_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CmpntHdrCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [cmpnt_hdr_cntnt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CMPNT_TXT_CNTNT] (
    [cmpnt_txt_cntnt_id] [NUMERIC](20,0) NOT NULL,
    [txt] [NVARCHAR](4000) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_CmpntTxtCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [cmpnt_txt_cntnt_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OIG_PLN_ORDR_CNTNT] (
    [oig_id] [NUMERIC](20,0) NOT NULL,
    [oig_pln_ordr_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OigPlnOrdrCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [oig_id] ASC,
  [oig_pln_ordr_cntnt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORDR] (
    [ordr_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Ordr] PRIMARY KEY NONCLUSTERED 
  (
  [ordr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORDR_STAT] (
    [ordr_id] [NUMERIC](20,0) NOT NULL,
    [ordr_stat_ix] [NUMERIC](20,0) NOT NULL,
    [exec_state_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrdrStat] PRIMARY KEY NONCLUSTERED 
  (
  [ordr_id] ASC,
  [ordr_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_POA] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [org_poa_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgPoa] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC,
  [pln_ordr_id] ASC,
  [org_poa_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ORG_POA_STAT] (
    [org_id] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [org_poa_ix] [NUMERIC](20,0) NOT NULL,
    [org_poa_stat_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [estblng_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_OrgPoaStat] PRIMARY KEY NONCLUSTERED 
  (
  [org_id] ASC,
  [pln_ordr_id] ASC,
  [org_poa_ix] ASC,
  [org_poa_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN] (
    [pln_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Pln] PRIMARY KEY NONCLUSTERED 
  (
  [pln_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN_ORDR] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlnOrdr] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POA] (
    [poa_subj_pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poa_obj_pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poa_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Poa] PRIMARY KEY NONCLUSTERED 
  (
  [poa_subj_pln_ordr_id] ASC,
  [poa_obj_pln_ordr_id] ASC,
  [poa_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POC] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poc_ix] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_Poc] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [poc_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POC_CNTNT] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poc_ix] [NUMERIC](20,0) NOT NULL,
    [poc_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [seq_ord] [NUMERIC](6,0),
    [cmpnt_hdr_cntnt_id] [NUMERIC](20,0) NOT NULL,
    [cmpnt_txt_cntnt_id] [NUMERIC](20,0),
    [poc_cntnt_data_contxt_id] [NUMERIC](20,0),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PocCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [poc_ix] ASC,
  [poc_cntnt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POC_CNTNT_REF] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poc_ix] [NUMERIC](20,0) NOT NULL,
    [poc_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [poc_cntnt_ref_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [ref_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PocCntntRef] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [poc_ix] ASC,
  [poc_cntnt_ix] ASC,
  [poc_cntnt_ref_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[POC_STRUCT] (
    [poc_struct_subj_pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poc_struct_subj_poc_ix] [NUMERIC](20,0) NOT NULL,
    [poc_struct_obj_pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [poc_struct_obj_poc_ix] [NUMERIC](20,0) NOT NULL,
    [poc_struct_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PocStruct] PRIMARY KEY NONCLUSTERED 
  (
  [poc_struct_subj_pln_ordr_id] ASC,
  [poc_struct_subj_poc_ix] ASC,
  [poc_struct_obj_pln_ordr_id] ASC,
  [poc_struct_obj_poc_ix] ASC,
  [poc_struct_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN_ORDR_DISTR] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_distr_ix] [NUMERIC](20,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [release_dttm] [CHAR](18),
    [recipient_org_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlnOrdrDistr] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [pln_ordr_distr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN_ORDR_DISTR_ACK] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_distr_ix] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_distr_ack_ix] [NUMERIC](20,0) NOT NULL,
    [code] [NVARCHAR](6) NOT NULL,
    [dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlnOrdrDistrAck] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [pln_ordr_distr_ix] ASC,
  [pln_ordr_distr_ack_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN_ORDR_HDR_CNTNT] (
    [pln_ordr_id] [NUMERIC](20,0) NOT NULL,
    [pln_ordr_hdr_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [name_txt] [NVARCHAR](50),
    [nickname_txt] [NVARCHAR](50),
    [serial_no_txt] [NVARCHAR](15),
    [sponsor_type_txt] [NVARCHAR](60),
    [time_zone_code] [NVARCHAR](6),
    [dttm] [CHAR](18) NOT NULL,
    [msg_ref_no_txt] [NVARCHAR](15),
    [security_clsfc_id] [NUMERIC](20,0),
    [place_of_issue_txt] [NVARCHAR](100),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlnOrdrHdrCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [pln_ordr_id] ASC,
  [pln_ordr_hdr_cntnt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PLN_STAT] (
    [pln_id] [NUMERIC](20,0) NOT NULL,
    [pln_stat_ix] [NUMERIC](20,0) NOT NULL,
    [dvlpm_stat_code] [NVARCHAR](6) NOT NULL,
    [state_code] [NVARCHAR](6),
    [dttm] [CHAR](18) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_PlnStat] PRIMARY KEY NONCLUSTERED 
  (
  [pln_id] ASC,
  [pln_stat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_CMT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_cmt_ix] [NUMERIC](20,0) NOT NULL,
    [symbol_annotation_txt] [NVARCHAR](20),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActCmt] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_cmt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_CMT] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_cmt_ix] [NUMERIC](20,0) NOT NULL,
    [symbol_annotation_txt] [NVARCHAR](20),
    [rptd_id] [NUMERIC](20,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemCmt] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_cmt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[IED_TAC_CHRTZN] (
    [act_event_id] [NUMERIC](20,0) NOT NULL,
    [act_event_det_ix] [NUMERIC](20,0) NOT NULL,
    [empl_code] [NVARCHAR](6),
    [employ_mthd_code] [NVARCHAR](6),
    [suicide_code] [NVARCHAR](6),
    [use_seq_code] [NVARCHAR](6),
    [vehicle_plcmnt_code] [NVARCHAR](6),
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_IedTacChrtzn] PRIMARY KEY NONCLUSTERED 
  (
  [act_event_id] ASC,
  [act_event_det_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ACT_CMT_CNTNT] (
    [act_id] [NUMERIC](20,0) NOT NULL,
    [act_cmt_ix] [NUMERIC](20,0) NOT NULL,
    [act_cmt_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [txt] [NVARCHAR](2000) NOT NULL,
    [seq_ord] [NUMERIC](2,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ActCmtCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [act_id] ASC,
  [act_cmt_ix] ASC,
  [act_cmt_cntnt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[OBJ_ITEM_CMT_CNTNT] (
    [obj_item_id] [NUMERIC](20,0) NOT NULL,
    [obj_item_cmt_ix] [NUMERIC](20,0) NOT NULL,
    [obj_item_cmt_cntnt_ix] [NUMERIC](20,0) NOT NULL,
    [txt] [NVARCHAR](2000) NOT NULL,
    [seq_ord] [NUMERIC](2,0) NOT NULL,
    [creator_id] [NUMERIC](20,0) NOT NULL,
    [update_seqnr] [NUMERIC](15,0) NOT NULL,
CONSTRAINT [PK_ObjItemCmtCntnt] PRIMARY KEY NONCLUSTERED 
  (
  [obj_item_id] ASC,
  [obj_item_cmt_ix] ASC,
  [obj_item_cmt_cntnt_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ALT_KEY] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [ak_ix] [NUMERIC](2,0) NOT NULL,
    [ak_no_qty] [NUMERIC](3,0) NOT NULL,
    [uniq_ind_code] [NVARCHAR](2) NOT NULL,
CONSTRAINT [PK_AltKey] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [ak_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[AK_ATTR] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
    [ak_ix] [NUMERIC](2,0) NOT NULL,
CONSTRAINT [PK_AkAttr] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [attr_ix] ASC,
  [ak_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ATTR] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
    [name_txt] [NVARCHAR](160) NOT NULL,
    [col_name_txt] [NVARCHAR](30) NOT NULL,
    [attr_seqnr_ord] [NUMERIC](3,0) NOT NULL,
    [pk_ind_code] [NVARCHAR](2) NOT NULL,
    [fk_ind_code] [NVARCHAR](2) NOT NULL,
    [stdn_lvl_code] [NVARCHAR](6) NOT NULL,
CONSTRAINT [PK_ATTR_PK] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [attr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BASE_ATTR] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
    [def_txt] [NVARCHAR](999) NOT NULL,
    [data_type_code] [NVARCHAR](7) NOT NULL,
    [data_len_cnt] [NUMERIC](4,0) NOT NULL,
    [data_dec_cnt] [NUMERIC](2,0),
    [dom_id] [NUMERIC](9,0) NOT NULL,
CONSTRAINT [PK_BaseAttr] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [attr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CARD_REL] (
    [pa_ent_id] [NUMERIC](8,0) NOT NULL,
    [ch_ent_id] [NUMERIC](8,0) NOT NULL,
    [rel_ix] [NUMERIC](2,0) NOT NULL,
    [verb_name_txt] [NVARCHAR](60) NOT NULL,
    [inv_verb_name_txt] [NVARCHAR](60),
    [ident_ind_code] [NVARCHAR](2) NOT NULL,
    [pa_card_code] [NVARCHAR](2) NOT NULL,
    [ch_card_code] [NVARCHAR](2) NOT NULL,
    [ch_mnm_card_cnt] [NUMERIC](3,0),
    [ch_max_card_cnt] [NUMERIC](3,0),
CONSTRAINT [PK_CardRel] PRIMARY KEY NONCLUSTERED 
  (
  [pa_ent_id] ASC,
  [ch_ent_id] ASC,
  [rel_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CAT] (
    [sup_ent_id] [NUMERIC](8,0) NOT NULL,
    [cat_ix] [NUMERIC](2,0) NOT NULL,
    [def_txt] [NVARCHAR](255),
    [discr_ix] [NUMERIC](6,0) NOT NULL,
    [compl_ind_code] [NVARCHAR](2) NOT NULL,
CONSTRAINT [PK_Cat] PRIMARY KEY NONCLUSTERED 
  (
  [sup_ent_id] ASC,
  [cat_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[DOM] (
    [dom_id] [NUMERIC](9,0) NOT NULL,
    [name_txt] [NVARCHAR](160) NOT NULL,
    [def_txt] [NVARCHAR](999) NOT NULL,
    [class_name_txt] [NVARCHAR](16) NOT NULL,
    [restr_type_code] [NVARCHAR](2),
    [meas_unit_descr_txt] [NVARCHAR](32),
    [pa_dom_id] [NUMERIC](9,0),
    [stdn_lvl_code] [NVARCHAR](6) NOT NULL,
    [mod_lvl_code] [NVARCHAR](4) NOT NULL,
    [def_src_txt] [NVARCHAR](100),
CONSTRAINT [PK_Dom] PRIMARY KEY NONCLUSTERED 
  (
  [dom_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[DOM_VAL] (
    [dom_id] [NUMERIC](9,0) NOT NULL,
    [dom_val_ix] [NUMERIC](12,0) NOT NULL,
    [descr_txt] [NVARCHAR](32) NOT NULL,
    [name_txt] [NVARCHAR](80),
    [def_txt] [NVARCHAR](999),
    [type_code] [NVARCHAR](6) NOT NULL,
    [stdn_lvl_code] [NVARCHAR](6) NOT NULL,
    [src_txt] [NVARCHAR](100),
CONSTRAINT [PK_DomVal] PRIMARY KEY NONCLUSTERED 
  (
  [dom_id] ASC,
  [dom_val_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[ENT] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [name_txt] [NVARCHAR](80) NOT NULL,
    [tab_name_txt] [NVARCHAR](30) NOT NULL,
    [def_txt] [NVARCHAR](999) NOT NULL,
    [depen_code] [NVARCHAR](2) NOT NULL,
    [depth_cnt] [NUMERIC](3,0) NOT NULL,
    [stg_type_code] [NVARCHAR](4) NOT NULL,
    [stdn_lvl_code] [NVARCHAR](6) NOT NULL,
    [mod_lvl_code] [NVARCHAR](4) NOT NULL,
CONSTRAINT [PK_Ent] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[FK_ATTR] (
    [host_ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
    [role_def_txt] [NVARCHAR](999),
    [rona_ind_code] [NVARCHAR](2) NOT NULL,
    [src_ent_id] [NUMERIC](8,0) NOT NULL,
    [src_attr_ix] [NUMERIC](6,0) NOT NULL,
    [migr_rel_ix] [NUMERIC](2,0) NOT NULL,
    [base_ent_id] [NUMERIC](8,0) NOT NULL,
    [base_attr_ix] [NUMERIC](6,0) NOT NULL,
    [unif_attr_ix] [NUMERIC](6,0),
CONSTRAINT [PK_FkAttr] PRIMARY KEY NONCLUSTERED 
  (
  [host_ent_id] ASC,
  [attr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[NK_ATTR] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
    [opt_ind_code] [NVARCHAR](2) NOT NULL,
CONSTRAINT [PK_NkAttr] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [attr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[PK_ATTR] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
CONSTRAINT [PK_PkAttr] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC,
  [attr_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[REL] (
    [pa_ent_id] [NUMERIC](8,0) NOT NULL,
    [ch_ent_id] [NUMERIC](8,0) NOT NULL,
    [rel_ix] [NUMERIC](2,0) NOT NULL,
    [type_code] [NVARCHAR](2) NOT NULL,
CONSTRAINT [PK_Rel] PRIMARY KEY NONCLUSTERED 
  (
  [pa_ent_id] ASC,
  [ch_ent_id] ASC,
  [rel_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[SUBT_REL] (
    [sup_ent_id] [NUMERIC](8,0) NOT NULL,
    [sub_ent_id] [NUMERIC](8,0) NOT NULL,
    [rel_ix] [NUMERIC](2,0) NOT NULL,
    [cat_ix] [NUMERIC](2,0) NOT NULL,
    [dom_id] [NUMERIC](9,0) NOT NULL,
    [dom_val_ix] [NUMERIC](12,0) NOT NULL,
CONSTRAINT [PK_SubtRel] PRIMARY KEY NONCLUSTERED 
  (
  [sup_ent_id] ASC,
  [sub_ent_id] ASC,
  [rel_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[CREATOR_UPDATE_IDENTIFIC] (
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [creator_attr_ix] [NUMERIC](6,0),
    [update_attr_ix] [NUMERIC](6,0),
CONSTRAINT [PK_CreatorUpdateIdentific] PRIMARY KEY NONCLUSTERED 
  (
  [ent_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BR] (
    [br_id] [NUMERIC](12,0) NOT NULL,
    [cat_code] [NVARCHAR](6) NOT NULL,
    [section_xref_txt] [NVARCHAR](15) NOT NULL,
    [name_txt] [NVARCHAR](999) NOT NULL,
    [def_txt] [NVARCHAR](999),
    [tab_xref_txt] [NVARCHAR](15),
CONSTRAINT [PK_Br] PRIMARY KEY NONCLUSTERED 
  (
  [br_id] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BR_ENT] (
    [br_id] [NUMERIC](12,0) NOT NULL,
    [br_ent_ix] [NUMERIC](12,0) NOT NULL,
    [ent_of_interest_id] [NUMERIC](8,0) NOT NULL,
CONSTRAINT [PK_BrEnt] PRIMARY KEY NONCLUSTERED 
  (
  [br_id] ASC,
  [br_ent_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BR_ENT_ATTR_COMP] (
    [br_id] [NUMERIC](12,0) NOT NULL,
    [br_ent_ix] [NUMERIC](12,0) NOT NULL,
    [br_ent_attr_comp_ix] [NUMERIC](12,0) NOT NULL,
    [null_ind_code] [NVARCHAR](6) NOT NULL,
    [ent_id] [NUMERIC](8,0) NOT NULL,
    [attr_ix] [NUMERIC](6,0) NOT NULL,
CONSTRAINT [PK_BrEntAttrComp] PRIMARY KEY NONCLUSTERED 
  (
  [br_id] ASC,
  [br_ent_ix] ASC,
  [br_ent_attr_comp_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [JC3IEDM].[BR_ENT_ATTR_COMP_DOM_VAL] (
    [br_id] [NUMERIC](12,0) NOT NULL,
    [br_ent_ix] [NUMERIC](12,0) NOT NULL,
    [br_ent_attr_comp_ix] [NUMERIC](12,0) NOT NULL,
    [br_ent_attr_comp_dom_val_ix] [NUMERIC](12,0) NOT NULL,
    [dom_id] [NUMERIC](9,0) NOT NULL,
    [dom_val_ix] [NUMERIC](12,0) NOT NULL,
CONSTRAINT [PK_BrEntAttrCompDomVal] PRIMARY KEY NONCLUSTERED 
  (
  [br_id] ASC,
  [br_ent_ix] ASC,
  [br_ent_attr_comp_ix] ASC,
  [br_ent_attr_comp_dom_val_ix] ASC
  ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [JC3IEDM].[ABS_POINT] WITH CHECK ADD CONSTRAINT [FK_CAT_POINT] FOREIGN KEY ([abs_point_id])
REFERENCES [JC3IEDM].[POINT] ([point_id])
GO

ALTER TABLE [JC3IEDM].[ACT_ACFT_EMPLOY] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES_EMPLOY] FOREIGN KEY ([act_id], [act_res_ix], [act_res_employ_ix])
REFERENCES [JC3IEDM].[ACT_RES_EMPLOY] ([act_id], [act_res_ix], [act_res_employ_ix])
GO




ALTER TABLE [JC3IEDM].[ACT_OBJVE_ITEM] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_OBJVE] FOREIGN KEY ([act_id], [act_objve_ix])
REFERENCES [JC3IEDM].[ACT_OBJVE] ([act_id], [act_objve_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_OBJVE_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_OBJVE] FOREIGN KEY ([act_id], [act_objve_ix])
REFERENCES [JC3IEDM].[ACT_OBJVE] ([act_id], [act_objve_ix])
GO



ALTER TABLE [JC3IEDM].[ACT_RES_ITEM] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES] FOREIGN KEY ([act_id], [act_res_ix])
REFERENCES [JC3IEDM].[ACT_RES] ([act_id], [act_res_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_RES_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES] FOREIGN KEY ([act_id], [act_res_ix])
REFERENCES [JC3IEDM].[ACT_RES] ([act_id], [act_res_ix])
GO

ALTER TABLE [JC3IEDM].[ATMOSPHERE] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([atmosphere_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[BRIDGE] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([bridge_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO

ALTER TABLE [JC3IEDM].[CLOUD_COVER] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([cloud_cover_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[CONE_VOL] WITH CHECK ADD CONSTRAINT [FK_CAT_GEOM_VOL] FOREIGN KEY ([cone_vol_id])
REFERENCES [JC3IEDM].[GEOM_VOL] ([geom_vol_id])
GO
ALTER TABLE [JC3IEDM].[CONS_MAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MAT_TYPE] FOREIGN KEY ([cons_mat_type_id])
REFERENCES [JC3IEDM].[MAT_TYPE] ([mat_type_id])
GO


ALTER TABLE [JC3IEDM].[CTRL_FEAT] WITH CHECK ADD CONSTRAINT [FK_CAT_FEAT] FOREIGN KEY ([ctrl_feat_id])
REFERENCES [JC3IEDM].[FEAT] ([feat_id])
GO
ALTER TABLE [JC3IEDM].[CTRL_FEAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FEAT_TYPE] FOREIGN KEY ([ctrl_feat_type_id])
REFERENCES [JC3IEDM].[FEAT_TYPE] ([feat_type_id])
GO
ALTER TABLE [JC3IEDM].[CONVOY] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG] FOREIGN KEY ([convoy_id])
REFERENCES [JC3IEDM].[ORG] ([org_id])
GO
ALTER TABLE [JC3IEDM].[ENG_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([eng_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MAT_TYPE] FOREIGN KEY ([eqpt_type_id])
REFERENCES [JC3IEDM].[MAT_TYPE] ([mat_type_id])
GO
ALTER TABLE [JC3IEDM].[FAC] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM] FOREIGN KEY ([fac_id])
REFERENCES [JC3IEDM].[OBJ_ITEM] ([obj_item_id])
GO
ALTER TABLE [JC3IEDM].[FAC_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_TYPE] FOREIGN KEY ([fac_type_id])
REFERENCES [JC3IEDM].[OBJ_TYPE] ([obj_type_id])
GO
ALTER TABLE [JC3IEDM].[FAN_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([fan_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[FEAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM] FOREIGN KEY ([feat_id])
REFERENCES [JC3IEDM].[OBJ_ITEM] ([obj_item_id])
GO
ALTER TABLE [JC3IEDM].[FEAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_TYPE] FOREIGN KEY ([feat_type_id])
REFERENCES [JC3IEDM].[OBJ_TYPE] ([obj_type_id])
GO
ALTER TABLE [JC3IEDM].[FIRE_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([fire_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[GEO_FEAT] WITH CHECK ADD CONSTRAINT [FK_CAT_FEAT] FOREIGN KEY ([geo_feat_id])
REFERENCES [JC3IEDM].[FEAT] ([feat_id])
GO
ALTER TABLE [JC3IEDM].[GEO_FEAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FEAT_TYPE] FOREIGN KEY ([geo_feat_type_id])
REFERENCES [JC3IEDM].[FEAT_TYPE] ([feat_type_id])
GO
ALTER TABLE [JC3IEDM].[GEOM_VOL] WITH CHECK ADD CONSTRAINT [FK_CAT_LOC] FOREIGN KEY ([geom_vol_id])
REFERENCES [JC3IEDM].[LOC] ([loc_id])
GO

ALTER TABLE [JC3IEDM].[LIGHT] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([light_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[LINE] WITH CHECK ADD CONSTRAINT [FK_CAT_LOC] FOREIGN KEY ([line_id])
REFERENCES [JC3IEDM].[LOC] ([loc_id])
GO


ALTER TABLE [JC3IEDM].[MAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM] FOREIGN KEY ([mat_id])
REFERENCES [JC3IEDM].[OBJ_ITEM] ([obj_item_id])
GO
ALTER TABLE [JC3IEDM].[MAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_TYPE] FOREIGN KEY ([mat_type_id])
REFERENCES [JC3IEDM].[OBJ_TYPE] ([obj_type_id])
GO
ALTER TABLE [JC3IEDM].[MET_FEAT] WITH CHECK ADD CONSTRAINT [FK_CAT_FEAT] FOREIGN KEY ([met_feat_id])
REFERENCES [JC3IEDM].[FEAT] ([feat_id])
GO
ALTER TABLE [JC3IEDM].[MNFLD] WITH CHECK ADD CONSTRAINT [FK_CAT_MIL_OBS] FOREIGN KEY ([mnfld_id])
REFERENCES [JC3IEDM].[MIL_OBS] ([mil_obs_id])
GO






ALTER TABLE [JC3IEDM].[ORG] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM] FOREIGN KEY ([org_id])
REFERENCES [JC3IEDM].[OBJ_ITEM] ([obj_item_id])
GO
ALTER TABLE [JC3IEDM].[ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_TYPE] FOREIGN KEY ([org_type_id])
REFERENCES [JC3IEDM].[OBJ_TYPE] ([obj_type_id])
GO
ALTER TABLE [JC3IEDM].[PERS] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM] FOREIGN KEY ([pers_id])
REFERENCES [JC3IEDM].[OBJ_ITEM] ([obj_item_id])
GO
ALTER TABLE [JC3IEDM].[PERS_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([pers_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[PERS_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_TYPE] FOREIGN KEY ([pers_type_id])
REFERENCES [JC3IEDM].[OBJ_TYPE] ([obj_type_id])
GO
ALTER TABLE [JC3IEDM].[POINT] WITH CHECK ADD CONSTRAINT [FK_CAT_LOC] FOREIGN KEY ([point_id])
REFERENCES [JC3IEDM].[LOC] ([loc_id])
GO
ALTER TABLE [JC3IEDM].[PRECIPITATION] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([precipitation_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[REL_POINT] WITH CHECK ADD CONSTRAINT [FK_CAT_POINT] FOREIGN KEY ([rel_point_id])
REFERENCES [JC3IEDM].[POINT] ([point_id])
GO
ALTER TABLE [JC3IEDM].[REQUEST] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_TASK] FOREIGN KEY ([request_id])
REFERENCES [JC3IEDM].[ACT_TASK] ([act_task_id])
GO


ALTER TABLE [JC3IEDM].[ROUTE] WITH CHECK ADD CONSTRAINT [FK_CAT_CTRL_FEAT] FOREIGN KEY ([route_id])
REFERENCES [JC3IEDM].[CTRL_FEAT] ([ctrl_feat_id])
GO

ALTER TABLE [JC3IEDM].[STORAGE_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([storage_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[SURF] WITH CHECK ADD CONSTRAINT [FK_CAT_LOC] FOREIGN KEY ([surf_id])
REFERENCES [JC3IEDM].[LOC] ([loc_id])
GO
ALTER TABLE [JC3IEDM].[SURV_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([surv_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[TARGET] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_OBJVE_ITEM] FOREIGN KEY ([act_id], [act_objve_ix])
REFERENCES [JC3IEDM].[ACT_OBJVE_ITEM] ([act_id], [act_objve_ix])
GO
ALTER TABLE [JC3IEDM].[UNIT] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG] FOREIGN KEY ([unit_id])
REFERENCES [JC3IEDM].[ORG] ([org_id])
GO
ALTER TABLE [JC3IEDM].[UNIT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MIL_ORG_TYPE] FOREIGN KEY ([unit_type_id], [supported_mil_org_type_id])
REFERENCES [JC3IEDM].[MIL_ORG_TYPE] ([mil_org_type_id], [mil_org_type_id])
GO
ALTER TABLE [JC3IEDM].[VISIBILITY] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([visibility_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[WIND] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([wind_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO
ALTER TABLE [JC3IEDM].[CFEAT_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([cfeat_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[FAC_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([fac_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[GFEAT_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([gfeat_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[MAT_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([mat_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[ORG_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_OBJ_ITEM_STAT] FOREIGN KEY ([org_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[OBJ_ITEM_STAT] ([obj_item_id], [obj_item_stat_ix])
GO




ALTER TABLE [JC3IEDM].[CTGTDET_ITEM] WITH CHECK ADD CONSTRAINT [FK_CAT_CTGTDET] FOREIGN KEY ([ctgtlst_id], [ctgtdet_item_ix])
REFERENCES [JC3IEDM].[CTGTDET] ([ctgtlst_id], [ctgtdet_ix])
GO
ALTER TABLE [JC3IEDM].[CTGTDET_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CTGTDET] FOREIGN KEY ([ctgtlst_id], [ctgtdet_type_ix])
REFERENCES [JC3IEDM].[CTGTDET] ([ctgtlst_id], [ctgtdet_ix])
GO




ALTER TABLE [JC3IEDM].[ACT_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT] FOREIGN KEY ([act_event_id])
REFERENCES [JC3IEDM].[ACT] ([act_id])
GO

ALTER TABLE [JC3IEDM].[ACT_TASK] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT] FOREIGN KEY ([act_task_id])
REFERENCES [JC3IEDM].[ACT] ([act_id])
GO

ALTER TABLE [JC3IEDM].[RPTD_ABS_TIMING] WITH CHECK ADD CONSTRAINT [FK_CAT_RPTD] FOREIGN KEY ([rptd_abs_timing_rptd_id])
REFERENCES [JC3IEDM].[RPTD] ([rptd_id])
GO
ALTER TABLE [JC3IEDM].[RPTD_REL_TIMING] WITH CHECK ADD CONSTRAINT [FK_CAT_RPTD] FOREIGN KEY ([rptd_rel_timing_rptd_id])
REFERENCES [JC3IEDM].[RPTD] ([rptd_id])
GO



ALTER TABLE [JC3IEDM].[ICING] WITH CHECK ADD CONSTRAINT [FK_CAT_MET_FEAT] FOREIGN KEY ([icing_id])
REFERENCES [JC3IEDM].[MET_FEAT] ([met_feat_id])
GO





ALTER TABLE [JC3IEDM].[MFS] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_STAT] FOREIGN KEY ([mfs_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[FAC_STAT] ([fac_stat_id], [obj_item_stat_ix])
GO






ALTER TABLE [JC3IEDM].[MOB_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([mob_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[ACFT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([acft_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[ELCTRNC_EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([elctrnc_eqpt_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[ENG_EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([eng_eqpt_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[WEAPON_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([weapon_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[MISC_EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([misc_eqpt_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[CBRN_EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([cbrn_eqpt_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[RAILCAR_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([railcar_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[VEHICLE_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([vehicle_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[VESSEL_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([vessel_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[BIO_MAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CONS_MAT_TYPE] FOREIGN KEY ([bio_mat_type_id])
REFERENCES [JC3IEDM].[CONS_MAT_TYPE] ([cons_mat_type_id])
GO
ALTER TABLE [JC3IEDM].[CHM_MAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CONS_MAT_TYPE] FOREIGN KEY ([chm_mat_type_id])
REFERENCES [JC3IEDM].[CONS_MAT_TYPE] ([cons_mat_type_id])
GO
ALTER TABLE [JC3IEDM].[CBRN_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_EVENT] FOREIGN KEY ([cbrn_event_id])
REFERENCES [JC3IEDM].[ACT_EVENT] ([act_event_id])
GO
ALTER TABLE [JC3IEDM].[RADACT_MAT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CONS_MAT_TYPE] FOREIGN KEY ([radact_mat_type_id])
REFERENCES [JC3IEDM].[CONS_MAT_TYPE] ([cons_mat_type_id])
GO
ALTER TABLE [JC3IEDM].[CIV_POST_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG_TYPE] FOREIGN KEY ([civ_post_type_id])
REFERENCES [JC3IEDM].[ORG_TYPE] ([org_type_id])
GO
ALTER TABLE [JC3IEDM].[EXCTV_MIL_ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MIL_ORG_TYPE] FOREIGN KEY ([exctv_mil_org_type_id])
REFERENCES [JC3IEDM].[MIL_ORG_TYPE] ([mil_org_type_id])
GO
ALTER TABLE [JC3IEDM].[GOVT_ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG_TYPE] FOREIGN KEY ([govt_org_type_id])
REFERENCES [JC3IEDM].[ORG_TYPE] ([org_type_id])
GO
ALTER TABLE [JC3IEDM].[GROUP_ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG_TYPE] FOREIGN KEY ([group_org_type_id])
REFERENCES [JC3IEDM].[ORG_TYPE] ([org_type_id])
GO
ALTER TABLE [JC3IEDM].[MIL_ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_GOVT_ORG_TYPE] FOREIGN KEY ([mil_org_type_id])
REFERENCES [JC3IEDM].[GOVT_ORG_TYPE] ([govt_org_type_id])
GO
ALTER TABLE [JC3IEDM].[MIL_POST_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MIL_ORG_TYPE] FOREIGN KEY ([mil_post_type_id])
REFERENCES [JC3IEDM].[MIL_ORG_TYPE] ([mil_org_type_id])
GO
ALTER TABLE [JC3IEDM].[PRV_SCTR_ORG_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ORG_TYPE] FOREIGN KEY ([prv_sctr_org_type_id])
REFERENCES [JC3IEDM].[ORG_TYPE] ([org_type_id])
GO
ALTER TABLE [JC3IEDM].[TASK_FRMTN_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_MIL_ORG_TYPE] FOREIGN KEY ([task_frmtn_type_id])
REFERENCES [JC3IEDM].[MIL_ORG_TYPE] ([mil_org_type_id])
GO



ALTER TABLE [JC3IEDM].[CORRIDOR_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([corridor_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[ELPS] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([elps_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[ORBIT_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([orbit_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[PLYRC_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([plyrc_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[POLYGON_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([polygon_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO
ALTER TABLE [JC3IEDM].[SPHERE_VOL] WITH CHECK ADD CONSTRAINT [FK_CAT_GEOM_VOL] FOREIGN KEY ([sphere_vol_id])
REFERENCES [JC3IEDM].[GEOM_VOL] ([geom_vol_id])
GO
ALTER TABLE [JC3IEDM].[SURF_VOL] WITH CHECK ADD CONSTRAINT [FK_CAT_GEOM_VOL] FOREIGN KEY ([surf_vol_id])
REFERENCES [JC3IEDM].[GEOM_VOL] ([geom_vol_id])
GO
ALTER TABLE [JC3IEDM].[TRACK_AREA] WITH CHECK ADD CONSTRAINT [FK_CAT_SURF] FOREIGN KEY ([track_area_id])
REFERENCES [JC3IEDM].[SURF] ([surf_id])
GO

ALTER TABLE [JC3IEDM].[AMMO_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CONS_MAT_TYPE] FOREIGN KEY ([ammo_type_id])
REFERENCES [JC3IEDM].[CONS_MAT_TYPE] ([cons_mat_type_id])
GO

ALTER TABLE [JC3IEDM].[AIRFIELD] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([airfield_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[BRIDGE_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_TYPE] FOREIGN KEY ([bridge_type_id])
REFERENCES [JC3IEDM].[FAC_TYPE] ([fac_type_id])
GO

ALTER TABLE [JC3IEDM].[OBJ_REF] WITH CHECK ADD CONSTRAINT [FK_CAT_REL_COORD_SYS] FOREIGN KEY ([rel_coord_sys_id])
REFERENCES [JC3IEDM].[REL_COORD_SYS] ([rel_coord_sys_id])
GO
ALTER TABLE [JC3IEDM].[POINT_REF] WITH CHECK ADD CONSTRAINT [FK_CAT_REL_COORD_SYS] FOREIGN KEY ([rel_coord_sys_id])
REFERENCES [JC3IEDM].[REL_COORD_SYS] ([rel_coord_sys_id])
GO
ALTER TABLE [JC3IEDM].[NETWRK] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([netwrk_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO


ALTER TABLE [JC3IEDM].[UXO_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_MAT_STAT] FOREIGN KEY ([uxo_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[MAT_STAT] ([mat_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_EFFECT_ITEM] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_EFFECT] FOREIGN KEY ([act_id], [act_effect_ix])
REFERENCES [JC3IEDM].[ACT_EFFECT] ([act_id], [act_effect_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_EFFECT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_EFFECT] FOREIGN KEY ([act_id], [act_effect_ix])
REFERENCES [JC3IEDM].[ACT_EFFECT] ([act_id], [act_effect_ix])
GO


ALTER TABLE [JC3IEDM].[ELCTRNC_ADDR] WITH CHECK ADD CONSTRAINT [FK_CAT_ADDR] FOREIGN KEY ([addr_id])
REFERENCES [JC3IEDM].[ADDR] ([addr_id])
GO
ALTER TABLE [JC3IEDM].[PHYSCL_ADDR] WITH CHECK ADD CONSTRAINT [FK_CAT_ADDR] FOREIGN KEY ([addr_id])
REFERENCES [JC3IEDM].[ADDR] ([addr_id])
GO





ALTER TABLE [JC3IEDM].[MIL_OBS_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_TYPE] FOREIGN KEY ([mil_obs_type_id])
REFERENCES [JC3IEDM].[FAC_TYPE] ([fac_type_id])
GO
ALTER TABLE [JC3IEDM].[MIL_OBS] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([mil_obs_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO





ALTER TABLE [JC3IEDM].[AFFL_ETHNIC_GROUP] WITH CHECK ADD CONSTRAINT [FK_CAT_AFFL] FOREIGN KEY ([affl_id])
REFERENCES [JC3IEDM].[AFFL] ([affl_id])
GO
ALTER TABLE [JC3IEDM].[AFFL_FUNCTL_GROUP] WITH CHECK ADD CONSTRAINT [FK_CAT_AFFL] FOREIGN KEY ([affl_id])
REFERENCES [JC3IEDM].[AFFL] ([affl_id])
GO
ALTER TABLE [JC3IEDM].[AFFL_GEOPOLITICAL] WITH CHECK ADD CONSTRAINT [FK_CAT_AFFL] FOREIGN KEY ([affl_id])
REFERENCES [JC3IEDM].[AFFL] ([affl_id])
GO
ALTER TABLE [JC3IEDM].[AFFL_RELIGION] WITH CHECK ADD CONSTRAINT [FK_CAT_AFFL] FOREIGN KEY ([affl_id])
REFERENCES [JC3IEDM].[AFFL] ([affl_id])
GO


ALTER TABLE [JC3IEDM].[HRBR] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([hrbr_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[ANCHR] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([anchr_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[BASIN] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([basin_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[BERTH] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([berth_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[DRY_DOCK] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([dry_dock_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[JETTY] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([jetty_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[QUAY] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([quay_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[SLPWAY] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([slpway_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO



ALTER TABLE [JC3IEDM].[RUNWAY] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([runway_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[MNFLD_LAND] WITH CHECK ADD CONSTRAINT [FK_CAT_MNFLD] FOREIGN KEY ([mnfld_land_id])
REFERENCES [JC3IEDM].[MNFLD] ([mnfld_id])
GO
ALTER TABLE [JC3IEDM].[MNFLD_MRT] WITH CHECK ADD CONSTRAINT [FK_CAT_MNFLD] FOREIGN KEY ([mnfld_mrt_id])
REFERENCES [JC3IEDM].[MNFLD] ([mnfld_id])
GO


ALTER TABLE [JC3IEDM].[LQD_SURF_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_GFEAT_STAT] FOREIGN KEY ([lqd_surf_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[GFEAT_STAT] ([gfeat_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[SLD_SURF_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_GFEAT_STAT] FOREIGN KEY ([sld_surf_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[GFEAT_STAT] ([gfeat_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[AIRFIELD_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_STAT] FOREIGN KEY ([airfield_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[FAC_STAT] ([fac_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[CRTS_POINT] WITH CHECK ADD CONSTRAINT [FK_CAT_ABS_POINT] FOREIGN KEY ([crts_point_id])
REFERENCES [JC3IEDM].[ABS_POINT] ([abs_point_id])
GO
ALTER TABLE [JC3IEDM].[GEO_POINT] WITH CHECK ADD CONSTRAINT [FK_CAT_ABS_POINT] FOREIGN KEY ([geo_point_id])
REFERENCES [JC3IEDM].[ABS_POINT] ([abs_point_id])
GO
ALTER TABLE [JC3IEDM].[AIR_ROUTE_SGMNT] WITH CHECK ADD CONSTRAINT [FK_CAT_ROUTE_SGMNT] FOREIGN KEY ([air_route_sgmnt_id])
REFERENCES [JC3IEDM].[ROUTE_SGMNT] ([route_sgmnt_id])
GO
ALTER TABLE [JC3IEDM].[ROUTE_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_CTRL_FEAT_TYPE] FOREIGN KEY ([route_type_id])
REFERENCES [JC3IEDM].[CTRL_FEAT_TYPE] ([ctrl_feat_type_id])
GO
ALTER TABLE [JC3IEDM].[ARSP_CTRL_MEANS] WITH CHECK ADD CONSTRAINT [FK_CAT_CTRL_FEAT] FOREIGN KEY ([arsp_ctrl_means_id])
REFERENCES [JC3IEDM].[CTRL_FEAT] ([ctrl_feat_id])
GO













ALTER TABLE [JC3IEDM].[OIG] WITH CHECK ADD CONSTRAINT [FK_CAT_CONTXT] FOREIGN KEY ([oig_id])
REFERENCES [JC3IEDM].[CONTXT] ([contxt_id])
GO


ALTER TABLE [JC3IEDM].[ACT_OBJVE_TASK] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_OBJVE] FOREIGN KEY ([act_id], [act_objve_ix])
REFERENCES [JC3IEDM].[ACT_OBJVE] ([act_id], [act_objve_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_RECCE_EMPLOY] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES_EMPLOY] FOREIGN KEY ([act_id], [act_res_ix], [act_res_employ_ix])
REFERENCES [JC3IEDM].[ACT_RES_EMPLOY] ([act_id], [act_res_ix], [act_res_employ_ix])
GO
ALTER TABLE [JC3IEDM].[ACT_OBJVE_TYPE_IMGRY_PROD] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_OBJVE_TYPE] FOREIGN KEY ([act_id], [act_objve_ix])
REFERENCES [JC3IEDM].[ACT_OBJVE_TYPE] ([act_id], [act_objve_ix])
GO

ALTER TABLE [JC3IEDM].[AIRFIELD_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_TYPE] FOREIGN KEY ([airfield_type_id])
REFERENCES [JC3IEDM].[FAC_TYPE] ([fac_type_id])
GO
ALTER TABLE [JC3IEDM].[ROUTE_SGMNT] WITH CHECK ADD CONSTRAINT [FK_CAT_CTRL_FEAT] FOREIGN KEY ([route_sgmnt_id])
REFERENCES [JC3IEDM].[CTRL_FEAT] ([ctrl_feat_id])
GO
ALTER TABLE [JC3IEDM].[RAILWAY] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([railway_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[ROAD] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([road_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[APRON] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC] FOREIGN KEY ([apron_id])
REFERENCES [JC3IEDM].[FAC] ([fac_id])
GO
ALTER TABLE [JC3IEDM].[CHM_BIO_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_CBRN_EVENT] FOREIGN KEY ([chm_bio_event_id])
REFERENCES [JC3IEDM].[CBRN_EVENT] ([cbrn_event_id])
GO
ALTER TABLE [JC3IEDM].[NUC_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_RADACT_EVENT] FOREIGN KEY ([nuc_event_id])
REFERENCES [JC3IEDM].[RADACT_EVENT] ([radact_event_id])
GO
ALTER TABLE [JC3IEDM].[NUC_WEAPON_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_NUC_EVENT] FOREIGN KEY ([nuc_weapon_event_id])
REFERENCES [JC3IEDM].[NUC_EVENT] ([nuc_event_id])
GO
ALTER TABLE [JC3IEDM].[RADACT_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_CBRN_EVENT] FOREIGN KEY ([radact_event_id])
REFERENCES [JC3IEDM].[CBRN_EVENT] ([cbrn_event_id])
GO
ALTER TABLE [JC3IEDM].[RADLGC_EVENT] WITH CHECK ADD CONSTRAINT [FK_CAT_RADACT_EVENT] FOREIGN KEY ([radlgc_event_id])
REFERENCES [JC3IEDM].[RADACT_EVENT] ([radact_event_id])
GO
ALTER TABLE [JC3IEDM].[ACT_ELCTRNC_WARFARE_EMPLOY] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES_EMPLOY] FOREIGN KEY ([act_id], [act_res_ix], [act_res_employ_ix])
REFERENCES [JC3IEDM].[ACT_RES_EMPLOY] ([act_id], [act_res_ix], [act_res_employ_ix])
GO
ALTER TABLE [JC3IEDM].[APPR_DIR] WITH CHECK ADD CONSTRAINT [FK_CAT_CTRL_FEAT] FOREIGN KEY ([appr_dir_id])
REFERENCES [JC3IEDM].[CTRL_FEAT] ([ctrl_feat_id])
GO

ALTER TABLE [JC3IEDM].[MRT_EQPT_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_EQPT_TYPE] FOREIGN KEY ([mrt_eqpt_type_id])
REFERENCES [JC3IEDM].[EQPT_TYPE] ([eqpt_type_id])
GO
ALTER TABLE [JC3IEDM].[SURF_VESSEL_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_VESSEL_TYPE] FOREIGN KEY ([surf_vessel_type_id])
REFERENCES [JC3IEDM].[VESSEL_TYPE] ([vessel_type_id])
GO
ALTER TABLE [JC3IEDM].[SUBSURF_VESSEL_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_VESSEL_TYPE] FOREIGN KEY ([subsurf_vessel_type_id])
REFERENCES [JC3IEDM].[VESSEL_TYPE] ([vessel_type_id])
GO
ALTER TABLE [JC3IEDM].[HRBR_TYPE] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_TYPE] FOREIGN KEY ([hrbr_type_id])
REFERENCES [JC3IEDM].[FAC_TYPE] ([fac_type_id])
GO
ALTER TABLE [JC3IEDM].[INST_LNDG_SYS] WITH CHECK ADD CONSTRAINT [FK_CAT_MAT] FOREIGN KEY ([inst_lndg_sys_id])
REFERENCES [JC3IEDM].[MAT] ([mat_id])
GO
ALTER TABLE [JC3IEDM].[MNFLD_MRT_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_FAC_STAT] FOREIGN KEY ([mnfld_mrt_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[FAC_STAT] ([fac_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[LQD_BODY_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_GFEAT_STAT] FOREIGN KEY ([lqd_body_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[GFEAT_STAT] ([gfeat_stat_id], [obj_item_stat_ix])
GO

ALTER TABLE [JC3IEDM].[ACT_MRT_EMPLOY] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_RES_EMPLOY] FOREIGN KEY ([act_id], [act_res_ix], [act_res_employ_ix])
REFERENCES [JC3IEDM].[ACT_RES_EMPLOY] ([act_id], [act_res_ix], [act_res_employ_ix])
GO
ALTER TABLE [JC3IEDM].[MINE_STAT] WITH CHECK ADD CONSTRAINT [FK_CAT_MAT_STAT] FOREIGN KEY ([mine_stat_id], [obj_item_stat_ix])
REFERENCES [JC3IEDM].[MAT_STAT] ([mat_stat_id], [obj_item_stat_ix])
GO
ALTER TABLE [JC3IEDM].[HNDL_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([hndl_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[MNT_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([mnt_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[SUPP_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([supp_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[TRNSM_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([trnsm_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO
ALTER TABLE [JC3IEDM].[OPERAT_CAPAB] WITH CHECK ADD CONSTRAINT [FK_CAT_CAPAB] FOREIGN KEY ([operat_capab_id])
REFERENCES [JC3IEDM].[CAPAB] ([capab_id])
GO





ALTER TABLE [JC3IEDM].[ORDR] WITH CHECK ADD CONSTRAINT [FK_CAT_PLN_ORDR] FOREIGN KEY ([ordr_id])
REFERENCES [JC3IEDM].[PLN_ORDR] ([pln_ordr_id])
GO



ALTER TABLE [JC3IEDM].[PLN] WITH CHECK ADD CONSTRAINT [FK_CAT_PLN_ORDR] FOREIGN KEY ([pln_id])
REFERENCES [JC3IEDM].[PLN_ORDR] ([pln_ordr_id])
GO












ALTER TABLE [JC3IEDM].[IED_TAC_CHRTZN] WITH CHECK ADD CONSTRAINT [FK_CAT_ACT_EVENT_DET] FOREIGN KEY ([act_event_id], [act_event_det_ix])
REFERENCES [JC3IEDM].[ACT_EVENT_DET] ([act_event_id], [act_event_det_ix])
GO






ALTER TABLE [JC3IEDM].[CARD_REL] WITH CHECK ADD CONSTRAINT [FK_CAT_REL] FOREIGN KEY ([pa_ent_id], [ch_ent_id], [rel_ix])
REFERENCES [JC3IEDM].[REL] ([pa_ent_id], [ch_ent_id], [rel_ix])
GO





ALTER TABLE [JC3IEDM].[NK_ATTR] WITH CHECK ADD CONSTRAINT [FK_CAT_ATTR] FOREIGN KEY ([ent_id], [attr_ix])
REFERENCES [JC3IEDM].[ATTR] ([ent_id], [attr_ix])
GO
ALTER TABLE [JC3IEDM].[PK_ATTR] WITH CHECK ADD CONSTRAINT [FK_CAT_ATTR] FOREIGN KEY ([ent_id], [attr_ix])
REFERENCES [JC3IEDM].[ATTR] ([ent_id], [attr_ix])
GO

ALTER TABLE [JC3IEDM].[SUBT_REL] WITH CHECK ADD CONSTRAINT [FK_CAT_REL] FOREIGN KEY ([sup_ent_id], [sub_ent_id], [rel_ix])
REFERENCES [JC3IEDM].[REL] ([pa_ent_id], [ch_ent_id], [rel_ix])
GO








